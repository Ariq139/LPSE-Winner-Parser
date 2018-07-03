from bs4 import BeautifulSoup as BS
import urllib.request
import string

id = str(input('Auction ID: '))
html = urllib.request.urlopen("https://lpse.ugm.ac.id/eproc4/evaluasi/"+id+"/pemenang")
#print(html.read())
soup = BS(html, 'html.parser')
#print(soup.prettify())
#print(soup.find_all('strong', limit=1))

name = soup.find_all('td')[0]
type = soup.find_all('td')[1]
winner = soup.find_all('strong')[0]

print(name.contents[0])
print(type.contents[0])
print(winner.contents[0])