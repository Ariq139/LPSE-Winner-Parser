#!/usr/bin/python3.7
from bs4 import BeautifulSoup as BS
import urllib.request, urllib.error, sys

totaldone = 0

def getURL(loc, auct_id):
    html = urllib.request.urlopen("http://lpse."+loc+".id/eproc4/lelang/"+auct_id+"/pengumumanlelang")
    soup = BS(html, 'html.parser')
    
    return soup

def getAuct(i, loc):
    
    global totaldone
    
    loc_check = ""
    loc_web = ""
    
    if loc == "ugm":
        loc_code = "303"
        loc_check = "UGM"
        loc_web += "ugm.ac"
    #elif str_id.endswith("367"):
        #loc += "kulonprogokab.go"
        #loc_localize += "LPSE Kulon Progo"
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
        
    try:
        temp = getURL(loc_web, str(i)+loc_code)
        
    except TimeoutError as e:
        print("Timeout.")
        getAuct(i+1, loc)
        return 0
        
    except urllib.error.HTTPError as e:
        print("The server couldn't fulfill the request.")
        print('Error code: ', e.code)
        if e.code != 500: #range id lelang out limit, halaman error
            return getAuct(i+1, loc)
        else:
            print("Total = "+totaldone)
            return 0
        
    except urllib.error.URLError as e:
        print('Failed to reach a server.')
        print('Reason: ', e.reason)
        return getAuct(i+1, loc)
    
    except RecursionError:
        getAuct(i+1, loc)
    
    else:
        if temp.find_all('td')[4].get_text() == "Lelang Sudah Selesai":
            print("Checking LPSE "+loc_check+"....("+str(i)+").....Hit!")
            totaldone += 1
            return getAuct(i+1, loc)
            
        elif temp.find_all('td')[4].get_text() == "Tidak Ada Jadwal":
            print("Checking LPSE "+loc_check+"....("+str(i)+")....Tidak Ada Jadwal")
            return getAuct(i+1, loc)
        
if __name__ == "__main__":
    loc = str(sys.argv[1])
    i = 0

    #elif str_id.endswith("367"):
        #loc += "kulonprogokab.go"
        #loc_localize += "LPSE Kulon Progo"
        
    if loc == "sleman":
        i = 2
    elif loc == "jogjaprov":
        i = 5
    else:
        i = 1

    getAuct(i, loc)