#!/usr/bin/python3.7
from bs4 import BeautifulSoup as BS
import urllib.request, urllib.error, sys, ssl
import winner_get

totaldone = 0
loc_code = ""
loc_check = ""
loc_web = ""

def getURL(loc, id):
    html = urllib.request.urlopen("http://lpse."+loc+".id/eproc4/lelang/"+id+"/pengumumanlelang")
    soup = BS(html, 'html.parser')
    
    return soup

def getURL_NoSSL(loc, id):
    context = ssl._create_unverified_context()
    html = urllib.request.urlopen("http://lpse."+loc+".id/eproc4/lelang/"+id+"/pengumumanlelang", context=context)
    soup = BS(html, 'html.parser')
    
    return soup

def checkLoc(loc):
    
    global loc_code
    global loc_check
    global loc_web
    
    if loc == "ugm":
        loc_code = "303"
        loc_check = "UGM"
        loc_web += "ugm.ac" #1
        
    elif loc == "kulonprogo":
        loc_code = "367"
        loc_web = "kulonprogokab.go"
        loc_check = "Kulon Progo" #2
        
    elif loc == "jogjakota":
        loc_code = "021"
        loc_check = "Yogyakarta Kota"
        loc_web = "jogjakota.go" #3
        
    elif loc == "sleman":
        loc_code = "054"
        loc_check = "Sleman"
        loc_web = "slemankab.go" #4
        
    elif loc == "jogjaprov":
        loc_code = "013"
        loc_check = "Provinsi Yogyakarta"
        loc_web = "jogjaprov.go" #5
        
    elif loc == "gunungkidul":
        loc_code = "621"
        loc_check = "Gunungkidul"
        loc_web = "gunungkidulkab.go" #6
        
    elif loc == "bantul":
        loc_code = "285"
        loc_check = "Bantul"
        loc_web = "bantulkab.go" #7
    
def getAuct(loc, start):
    
    global totaldone
    global loc_code
    global loc_check
    global loc_web
    global auctID
    
    broken = False
    
    checkLoc(loc)
    
    auctID = start
        
    while broken == False:
        try:
            if loc != "sleman":
                temp = getURL(loc_web, str(auctID)+loc_code)
            else:
                temp = getURL_NoSSL(loc_web, str(auctID)+loc_code)
        except TimeoutError as e:
            print("Timeout.")
            auctID += 0
        
        except urllib.error.HTTPError as e:
            print('Error code: ', e.code)
            if str(e.code) != "500": #range id lelang out limit/halaman error
                auctID += 1
            else: #failsafe
                if auctID < 2900 and loc == "sleman":
                    auctID += 1 #ssl cert error
                elif auctID < 3400 and loc == "jogjakota":
                    auctID += 1 
                elif auctID < 6000 and loc == "jogjaprov":
                    auctID += 1
                elif auctID < 1100 and loc == "ugm":
                    auctID += 1
                elif auctID < 1800 and loc == "gunungkidul":
                    auctID += 1
                elif auctID < 2200 and loc == "bantul":
                    auctID += 1
                elif auctID < 2100 and loc == "kulonprogo":
                    auctID += 1
                else:
                    broken = True
                    print("Total = "+ str(totaldone) + ", stopped at "+str(auctID)+loc_code)
                    
        except urllib.error.URLError as e:
            print('Failed to reach a server.')
            print('Reason: ', e.reason)
            auctID += 1
    
        else:
            if temp.find_all('td')[4].get_text() == "Lelang Sudah Selesai" or temp.find_all('td')[9].get_text() == "Lelang Sudah Selesai" or temp.find_all('td')[5].get_text() == "Lelang Sudah Selesai" or temp.find_all('td')[10].get_text() == "Lelang Sudah Selesai":
                print("Checking LPSE "+loc_check+"....("+str(auctID)+").....Hit!")
                totaldone += 1
                winner_get.getData(str(auctID)+loc_code, loc)
                auctID += 1
            else:
                print("Checking LPSE "+loc_check+"....("+str(auctID)+").....Miss!")
                #print(temp.find_all('td')[4].get_text())
                auctID += 1
        
if __name__ == "__main__":
    loc = str(sys.argv[1])
    start = int(sys.argv[2])

    getAuct(loc, start)