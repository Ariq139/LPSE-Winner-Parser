from bs4 import BeautifulSoup as BS
import urllib.request, urllib.error

id = int(input('Auction ID: '))
str_id = str(id)
#web = str(input('Site: '))
#print("NOTE: Area Jogja")
try:
    html = urllib.request.urlopen("https://lpse.ugm.ac.id/eproc4/evaluasi/"+str_id+"/pemenang")
    #print(html.read())
    soup = BS(html, 'html.parser')
    #print(soup.prettify())
    #print(soup.find_all('strong', limit=1))

except urllib.error.HTTPError as e:
    print('The server couldn\'t fulfill the request.')
    print('Error code: ', e.code)
except urllib.error.URLError as e:
    print('Failed to reach a server.')
    print('Reason: ', e.reason)
else:
    name = soup.find_all('td')[0]
    type = soup.find_all('td')[1]
    winner = soup.find_all('td')[6]
    [s.extract() for s in soup('strong')]

    print(name.contents[0])
    print(type.contents[0])
    print(winner.contents[0])

