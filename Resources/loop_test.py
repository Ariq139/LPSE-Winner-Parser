from bs4 import BeautifulSoup as BS
import urllib.request

count = 0
code = 1303
max_code_as_of_development = 1055303 #fallback bila file terhapus
max_finished_code_as_of_development = 1049303

latest = open("guru99.txt","w+")

while 