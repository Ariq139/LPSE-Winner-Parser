#!/usr/bin/python3.7
from bs4 import BeautifulSoup as BS
import urllib.request, urllib.error, sys
import winner_get

totaldone = 0
loc_code = ""
loc_check = ""
loc_web = ""
auctID = 1

def getURL(loc, id):
    html = urllib.request.urlopen("http://lpse."+loc+".id/eproc4/lelang/"+id+"/pengumumanlelang")
    soup = BS(html, 'html.parser')
    
    return soup

def checkLoc(loc):
    
    global loc_code
    global loc_check
    global loc_web
    
    if loc == "ugm":
        loc_code = "303"
        loc_check = "UGM"
        loc_web += "ugm.ac"
        
    #elif str_id.endswith("367"):
        #loc += "kulonprogokab.go"
        #loc_localize += "LPSE Kulon Progo"
        #website lpse kulon progo banyak problem (ngga bisa load, dsb)
        
    elif loc == "jogjakota":
        loc_code = "021"
        loc_check = "Yogyakarta Kota"
        loc_web = "jogjakota.go"
        
    elif loc == "sleman":
        loc_code = "054"
        loc_check = "Sleman"
        loc_web = "slemankab.go"
        
    elif loc == "jogjaprov":
        loc_code = "013"
        loc_check = "Provinsi Yogyakarta"
        loc_web = "jogjaprov.go"
        
    elif loc == "gunungkidul":
        loc_code = "621"
        loc_check = "Gunungkidul"
        loc_web = "gunungkidulkab.go"
        
    elif loc == "bantul":
        loc_code = "285"
        loc_check = "Bantul"
        loc_web = "bantulkab.go"
    
def getAuct(loc):
    
    global totaldone
    global loc_code
    global loc_check
    global loc_web
    global auctID
    
    broken = False
    
    checkLoc(loc)
        
    while broken == False:
        try:
            temp = getURL(loc_web, str(auctID)+loc_code)
        
        except TimeoutError as e:
            print("Connection Timeout. Check your connections.")
            auctID += 0
        
        except urllib.error.HTTPError as e:
            print("The server couldn't fulfill the request.")
            print('Error code: ', e.code)
            if str(e.code) != "500": #range id lelang out limit, halaman error
                auctID += 1
            else: #failsafe
                if auctID < 2600 and loc == "sleman":
                    auctID += 1
                elif auctID < 3400 and loc == "jogjakota":
                    auctID += 1 #down juga?
                elif auctID < 5000 and loc == "jogjaprov":
                    auctID += 1
                elif auctID < 1000 and loc == "ugm":
                    auctID += 1
                #elif auctID < 1000 and loc == "gunungkidulkab":
                    #auctID += 1 #websitenya down
                #elif auctID < 1000 and loc == "bantulkab":
                    #auctID += 1 #websitenya down    
                else:
                    broken = True
                    print("Total = "+ str(totaldone))
                    
        except urllib.error.URLError as e:
            print('Failed to reach a server.')
            print('Reason: ', e.reason)
            auctID += 1
    
        else:
            if temp.find_all('td')[4].get_text() == "Lelang Sudah Selesai":
                print("Checking LPSE "+loc_check+"....("+str(auctID)+").....Hit!")
                totaldone += 1
                winner_get.getData(str(auctID)+loc_code, totaldone)
                auctID += 1
            
            else:
                print("Checking LPSE "+loc_check+"....("+str(auctID)+").....Miss!")
                auctID += 1
        
if __name__ == "__main__":
    loc = str(sys.argv[1])

    getAuct(loc)