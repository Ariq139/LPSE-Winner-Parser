#!/usr/bin/python3.7
from bs4 import BeautifulSoup as BS
import urllib.request, urllib.error, sys, ssl, mysql.connector

#def getURL_NoSSL(loc, id):
#    context = ssl._create_unverified_context()
#    html = urllib.request.urlopen("http://lpse."+loc+".id/eproc4/lelang/"+id+"/pengumumanlelang", context=context)
#    soup = BS(html, 'html.parser')
    
#    return soup
    
def getPlaces():
    html = urllib.request.urlopen("https://inaproc.lkpp.go.id/v3/daftar_lpse")
    #print(html.read())
    soup = BS(html, 'html.parser')
    print(soup.prettify())
    
#def getCategory():
    
if __name__ == "__main__":
    getPlaces()
    #getCategory()
    