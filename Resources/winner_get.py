#!/usr/bin/python3.7
from bs4 import BeautifulSoup as BS
import urllib.request, urllib.error, sys, ssl
import mysql_write

def linkConnect_Pengumuman(link, kode_lelang):
    context = ssl._create_unverified_context()
    html = urllib.request.urlopen(link + "/eproc4/lelang/" + kode_lelang + "/pengumumanlelang", context=context)
                
    soup = BS(html, 'html.parser')
    
    return soup
    
def linkConnect_Peserta(link, kode_lelang):
    context = ssl._create_unverified_context()
    html = urllib.request.urlopen(link + "/eproc4/lelang/" + kode_lelang + "/peserta", context=context)
                
    soup = BS(html, 'html.parser')
    
    return soup

def linkConnect_Evaluasi(link, kode_lelang):
    context = ssl._create_unverified_context()
    html = urllib.request.urlopen(link + "/eproc4/evaluasi/" + kode_lelang + "/hasil", context=context)
                
    soup = BS(html, 'html.parser')
    
    return soup

def linkConnect_Pemenang(link, kode_lelang):
    context = ssl._create_unverified_context()
    html = urllib.request.urlopen(link + "/eproc4/evaluasi/" + kode_lelang + "/pemenang", context=context)
                
    soup = BS(html, 'html.parser')
    
    return soup
    
def linkConnect_PemenangBerkontrak(link, kode_lelang):
    context = ssl._create_unverified_context()
    html = urllib.request.urlopen(link + "/eproc4/evaluasi/" + kode_lelang + "/pemenangberkontrak", context=context)
                
    soup = BS(html, 'html.parser')
    
    return soup
    
def linkConnect_Tahap(link, kode_lelang):
    context = ssl._create_unverified_context()
    html = urllib.request.urlopen(link + "/eproc4/lelang/" + kode_lelang + "/jadwal", context=context)
                
    soup = BS(html, 'html.parser')
    
    return soup
    

    
def getData_Pengumuman(retry_limit, link, kode_lelang):
    soup = None
    linkGet = False
    
    #id_lelang = kode_lelang disini
    nama = ""
    tgl_buat = ""
    tahap = ""
    instansi = ""
    satker = ""
    kategori = ""
    thn_angg = ""
    pagu = ""
    hps = ""
    jml_peserta = ""
    
    #ambil "koneksi"
    for j in range(0, retry_limit): 
        try:
            soup = linkConnect_Pengumuman(link, kode_lelang)
                
            linkGet = True
            print("Connection to Pengumuman established.")
            break
        
        except urllib.error.HTTPError as e:
            print('Error: ', e.code)
                
        except urllib.error.URLError as e:
            print('Error: ', e.reason)
                
    if linkGet:
    
        #dibuat banyak forloop karena biar lebih sedikit pencocokan stringnya daripada kalau digabung
    
        for tmp in range(0, len(soup.find_all('th'))):
            if soup.find_all('th')[tmp].get_text() == "Nama Lelang":
                nama = soup.find_all('td')[tmp].get_text()
                break
                
        for tmp in range(0, len(soup.find_all('th'))):
            if soup.find_all('th')[tmp].get_text() == "Tanggal Pembuatan":
                break
                
        for tmp in range(0, len(soup.find_all('th'))):
            if soup.find_all('th')[tmp].get_text() == "Tahap Lelang Saat ini":
                tahap = soup.find_all('td')[tmp].get_text()
                break
                
        for tmp in range(0, len(soup.find_all('th'))):
            if soup.find_all('th')[tmp].get_text() == "Instansi":
                instansi = soup.find_all('td')[tmp].get_text()
                break
                
        for tmp in range(0, len(soup.find_all('th'))):
            if soup.find_all('th')[tmp].get_text() == "Satuan Kerja":
                satker = soup.find_all('td')[tmp].get_text()
                break
                
        for tmp in range(0, len(soup.find_all('th'))):
            if soup.find_all('th')[tmp].get_text() == "Kategori":
                kategori = soup.find_all('td')[tmp].get_text()
                break
                
        for tmp in range(0, len(soup.find_all('th'))):
            if soup.find_all('th')[tmp].get_text() == "Tahun Anggaran":
                thn_angg = soup.find_all('td')[tmp].get_text()
                break
                
        for tmp in range(0, len(soup.find_all('th'))):
            if soup.find_all('th')[tmp].get_text() == "Nilai Pagu Paket":
                pagu = soup.find_all('td')[tmp].get_text()[2:] #hapus Rp
                break
                    
        for tmp in range(0, len(soup.find_all('th'))):
            if soup.find_all('th')[tmp].get_text() == "Nilai HPS Paket":
                hps = soup.find_all('td')[tmp].get_text()[2:] #hapus Rp
                break
                
        for tmp in range(0, len(soup.find_all('th'))): #USE WITH CAUTION
            if soup.find_all('th')[tmp].get_text() == "Kualifikasi Usaha":
                kualifikasi = soup.find_all('td')[tmp-1].get_text()
                break
                
        tmp1, tmp2 = soup.find_all('td')[len(soup.find_all('td'))-1].get_text().split() #hapus kata peserta, ambil angkanya
        jml_peserta = tmp1
        
        print(kode_lelang, nama, tgl_buat, tahap, instansi, satker, kategori, thn_angg, pagu, hps, kualifikasi, jml_peserta) #ganti fungsi biar masuk ke tabel

def getData_Peserta(retry_limit, link, kode_lelang):
    soup = None
    linkGet = False
    
    #ambil "koneksi"
    for j in range(0, retry_limit): 
        try:
            soup = linkConnect_Peserta(link, kode_lelang)
                
            linkGet = True
            break
        
        except urllib.error.HTTPError as e:
            print('Error: ', e.code)
                
        except urllib.error.URLError as e:
            print('Error: ', e.reason)
                
    if linkGet:
        i = 1
        while i < len(soup.find_all('td')):
            nama = soup.find_all('td')[i].get_text()
            npwp = soup.find_all('td')[i+1].get_text()
            penawaran = soup.find_all('td')[i+2].get_text()
            terkoreksi = soup.find_all('td')[i+3].get_text()
            
            i += 5
            
            print(kode_lelang, nama, npwp, penawaran, terkoreksi) #ganti fungsi biar masuk ke tabel
         
def getData_Evaluasi(retry_limit, link, kode_lelang):
    soup = None
    linkGet = False
    
    #ambil "koneksi"
    for j in range(0, retry_limit): 
        try:
            soup = linkConnect_Evaluasi(link, kode_lelang)
                
            linkGet = True
            break
        
        except urllib.error.HTTPError as e:
            print('Error: ', e.code)
                
        except urllib.error.URLError as e:
            print('Error: ', e.reason)
                
    if linkGet:
        i = 1
        while i < len(soup.find_all('td')):
            tmp1, tmp2 = soup.find_all('td')[i].get_text().split(' - ') #pisah nama perusahaan dan npwp
            
            npwp = tmp2
            
            if soup.find_all('td')[i+1].contents != []:
                k = True
            else:
                k = False
            
            if soup.find_all('td')[i+2].contents != []:
                a = True
            else:
                a = False
            
            if soup.find_all('td')[i+3].contents != []:
                t = True
            else:
                t = False
            
            penawaran = soup.find_all('td')[i+4].get_text()[2:]
            terkoreksi = soup.find_all('td')[i+5].get_text()[2:]
            
            if soup.find_all('td')[i+6].contents != []:
                h = True
            else:
                h = False
            
            if soup.find_all('td')[i+7].contents != []:
                p = True
            else:
                p = False
            
            if soup.find_all('td')[i+8].contents != []:
                pk = True
            else:
                pk = False
            
            alasan = soup.find_all('td')[i+9].get_text()
            
            i += 11
            
            print(kode_lelang, npwp, k, a, t, penawaran, terkoreksi, h, p, pk, alasan) #ganti fungsi biar masuk ke tabel
            
def getData_Tahap(retry_limit, link, kode_lelang):
    soup = None
    linkGet = False
    
    #ambil "koneksi"
    for j in range(0, retry_limit): 
        try:
            soup = linkConnect_Tahap(link, kode_lelang)
                
            linkGet = True
            break
        
        except urllib.error.HTTPError as e:
            print('Error: ', e.code)
                
        except urllib.error.URLError as e:
            print('Error: ', e.reason)
                
    if linkGet:
        i = 1
        while i < len(soup.find_all('td')):
            tahap = soup.find_all('td')[i].get_text()
            mulai = soup.find_all('td')[i+1].get_text()
            sampai = soup.find_all('td')[i+2].get_text()
            
            i += 5
            
            print(kode_lelang, tahap, mulai, sampai) #ganti fungsi biar masuk ke tabel

def getData_Pemenang(retry_limit, link, kode_lelang):
    soup = None
    linkGet = False
    
    #ambil "koneksi"
    for j in range(0, retry_limit): 
        try:
            soup = linkConnect_Pemenang(link, kode_lelang)
                
            linkGet = True
            break
        
        except urllib.error.HTTPError as e:
            print('Error: ', e.code)
                
        except urllib.error.URLError as e:
            print('Error: ', e.reason)
                
    try:
        if linkGet:
            for tmp in range(0, len(soup.find_all('th'))):
                if soup.find_all('th')[tmp].get_text() == "NPWP":
                    npwp = soup.find_all('td')[tmp+1].get_text() #USE WITH CAUTION
                    break
            
            print(kode_lelang, npwp)
            
    except IndexError:
        for j in range(0, retry_limit): 
            try:
                soup = linkConnect_PemenangBerkontrak(link, kode_lelang)
                
                linkGet = True
                break
        
            except urllib.error.HTTPError as e:
                print('Error: ', e.code)
                
            except urllib.error.URLError as e:
                print('Error: ', e.reason)
                
        if linkGet:
            for tmp in range(0, len(soup.find_all('th'))):
                if soup.find_all('th')[tmp].get_text() == "NPWP":
                    nama = soup.find_all('td')[tmp+1].get_text() #USE WITH CAUTION
                    break
                        
            print(kode_lelang, npwp)
            
def getData_PemenangDetail(retry_limit, link, kode_lelang):
    soup = None
    linkGet = False
    
    #ambil "koneksi"
    for j in range(0, retry_limit): 
        try:
            soup = linkConnect_Pemenang(link, kode_lelang)
                
            linkGet = True
            break
        
        except urllib.error.HTTPError as e:
            print('Error: ', e.code)
                
        except urllib.error.URLError as e:
            print('Error: ', e.reason)
                
    try:
        if linkGet:
            for tmp in range(0, len(soup.find_all('th'))):
                if soup.find_all('th')[tmp].get_text() == "NPWP":
                    npwp = soup.find_all('td')[tmp+1].get_text() #USE WITH CAUTION
                    break
            
            for tmp in range(0, len(soup.find_all('th'))):
                if soup.find_all('th')[tmp].get_text() == "Nama Pemenang":
                    nama = soup.find_all('td')[tmp+1].get_text() #USE WITH CAUTION
                    break
            
            for tmp in range(0, len(soup.find_all('th'))):
                if soup.find_all('th')[tmp].get_text() == "Alamat":
                    alamat = soup.find_all('td')[tmp+1].get_text() #USE WITH CAUTION
                    break
            
            print(npwp, nama, alamat)
            
    except IndexError:
        for j in range(0, retry_limit): 
            try:
                soup = linkConnect_PemenangBerkontrak(link, kode_lelang)
                
                linkGet = True
                break
        
            except urllib.error.HTTPError as e:
                print('Error: ', e.code)
                
            except urllib.error.URLError as e:
                print('Error: ', e.reason)
                
        if linkGet:
            for tmp in range(0, len(soup.find_all('th'))):
                if soup.find_all('th')[tmp].get_text() == "NPWP":
                    nama = soup.find_all('td')[tmp+1].get_text() #USE WITH CAUTION
                    break
                        
            print(kode_lelang, npwp)
                
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
    
    #mulai dari start sampai end, input dari UI
    for run in range(start_point, end_point+1): #i=start_point;i<end_point+1;i++
        kode_lelang = str(run) + lpse_code
        
        getData_Pengumuman(retry_limit, link, kode_lelang) #tabel lelang
        getData_Peserta(retry_limit, link, kode_lelang) #tabel peserta
        getData_Tahap(retry_limit, link, kode_lelang) #tabel tahap
        getData_Evaluasi(retry_limit, link, kode_lelang) #tabel evaluasi
        getData_Pemenang(retry_limit, link, kode_lelang)
        getData_PemenangDetail(retry_limit, link, kode_lelang)