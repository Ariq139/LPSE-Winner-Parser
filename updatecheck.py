from bs4 import BeautifulSoup as BS
import urllib.request, urllib.error, sys

def getURL(loc, auct_id):
    html = urllib.request.urlopen("http://lpse."+loc+".id/eproc4/lelang/"+auct_id+"/pengumumanlelang")
    soup = BS(html, 'html.parser')
    
    return soup

def getAuct(i):
    print("Checking LPSE UGM....")
    try:
        temp = getURL("ugm.ac", str(i)+"303")
        if temp.find_all('td')[4].get_text() == "Lelang Sudah Selesai":
            #getAuct(i+1)
            print("check")
        #if temp.find_all('title')[0].contents[0] == "Error":
            #print("Total lelang yang sudah selesai: "+str(i)+"\n")
        #elif temp.find_all('title')[0].contents[0] == "Akses Ditolak":
            #getAuct(i+1)
            #print("skip")
    except (urllib.error.HTTPError, urllib.error.URLError, TimeoutError) as e:
        print("connect error")
if __name__ == "__main__":
    i = 1
    getAuct(i)