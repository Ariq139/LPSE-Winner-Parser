#!/usr/bin/python3.7
from bs4 import BeautifulSoup as BS
import urllib.request, urllib.error, sys, ssl
import mysql_write

def getData(location, start_point, end_point, retry_limit, link, code):
    for i in range(start_point, end_point):
        for j in range(retry_limit):
            try:
                context = ssl._create_unverified_context()
                html = urllib.request.urlopen(link + "/eproc4/evaluasi/" + str(i) + str(code) + "/pemenang", context=context)
                
                soup = BS(html, 'html.parser')
        
            except urllib.error.HTTPError as e:
                print('Error: ', e.code)
                #break #automatically end the for loop
                
            except urllib.error.URLError as e:
                print('Error: ', e.reason)
                
            #print('\n')

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
    location = str(sys.argv[1])
    start_point = str(sys.argv[2])
    end_point = str(sys.argv[3])
    timeout = int(sys.argv[4])
    retry_limit = int(sys.argv[5])

    test(location, start_point, end_point, retry_limit, link, lpse_code)