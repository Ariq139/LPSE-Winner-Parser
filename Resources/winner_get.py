#!/usr/bin/python3.7
from bs4 import BeautifulSoup as BS
import urllib.request, urllib.error, sys, ssl
import mysql_write

def getData_Pengumuman(start_point, end_point, retry_limit, link, lpse_code):
    for i in range(start_point, end_point+1): #mulai dari start sampai end, dari UI
        for j in range(0, retry_limit): #
            try:
                context = ssl._create_unverified_context()
                html = urllib.request.urlopen(link + "/eproc4/lelang/" + str(i) + str(lpse_code) + "/pengumumanlelang", context=context)
                
                soup = BS(html, 'html.parser')
                print("get link done")
                
                break
        
            except urllib.error.HTTPError as e:
                print('Error: ', e.code)
                
            except urllib.error.URLError as e:
                print('Error: ', e.reason)
        
        for j in range(0, retry_limit):
            for tmp in range(0, len(soup.find_all('th'))):
                if soup.find_all('th')[tmp] == "Kode Lelang":
                    print(soup.find_all('td')[tmp])
                    break
            
            break
        break
def test(location, start_point, end_point, timeout, retry_limit):
    print(location)
    print(start_point)
    print(end_point)
    print(timeout)
    print(retry_limit)
    #input("PRESS ENTER TO CONTINUE.")

    #cursor1.execute("select djname from jerryins_djleaderboard.leaderboard where djname = %s", dj)
    #result = cursor1.fetchall()
    #for row in result:
        #print row[0]

if __name__ == "__main__":
    start_point = int(sys.argv[1])
    end_point = int(sys.argv[2])
    retry_limit = int(sys.argv[3])
    link = str(sys.argv[4])
    lpse_code = str(sys.argv[5])

    getData_Pengumuman(start_point, end_point, retry_limit, link, lpse_code)