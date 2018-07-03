from bs4 import BeautifulSoup as BS
import urllib.request
id = str(int(input('Auction ID: ')))
html = urllib.request.urlopen("https://lpse.ugm.ac.id/eproc4/evaluasi/"+id+"/pemenang")
#print(html.read())
soup = BS(html, 'html.parser')
#print(soup.prettify())
print(soup.find_all('strong', limit=1))