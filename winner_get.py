from bs4 import BeautifulSoup as BS
import urllib.request, urllib.error, sys

if __name__ == "__main__":
    auct_id = int(sys.argv[1])
    #loc = str(sys.argv[2])
    loc = ""
    loc_localize = ""
    
    str_id = str(auct_id)
    if str_id.endswith("303"):
        loc += "ugm.ac"
        loc_localize += "LPSE UGM"
    elif str_id.endswith("367"):
        loc += "kulonprogokab.go"
        loc_localize += "LPSE Kulon Progo"
    elif str_id.endswith("021"):
        loc += "jogjakota.go"
        loc_localize += "LPSE Yogyakarta Kota"
    elif str_id.endswith("054"):
        loc += "slemankab.go"
        loc_localize += "LPSE Sleman"
    elif str_id.endswith("013"):
        loc += "jogjaprov.go"
        loc_localize += "LPSE Provinsi Yogyakarta"
    elif str_id.endswith("621"):
        loc += "gunungkidulkab.go"
        loc_localize += "LPSE Gunungkidul"
    elif str_id.endswith("285"):
        loc += "bantulkab.go"
        loc_localize += "LPSE Bantul"
    
    #web = str(input('Site: '))
    #print("NOTE: Area Jogja")
    try:
        html = urllib.request.urlopen("http://lpse."+loc+".id/eproc4/evaluasi/"+str_id+"/pemenang")
        #print(html.read())
        soup = BS(html, 'html.parser')
        #print(soup.prettify())
        #print(soup.find_all('strong', limit=1))

    except urllib.error.HTTPError as e:
        print("The server couldn't fulfill the request.")
        print('Error code: ', e.code)
        
    except urllib.error.URLError as e:
        print('Failed to reach a server.')
        print('Reason: ', e.reason)
    else:
        try:
            name = soup.find_all('td')[0]
            type = soup.find_all('td')[1]
            winner = soup.find_all('td')[7]
        
            print("Lokasi:", loc_localize, "\n")
            print(name.get_text())
            print(type.get_text())
            print(winner.get_text())
        except IndexError:
            print("Lokasi:", loc_localize, "\n")
            print("Pemenang tidak ditemukan")