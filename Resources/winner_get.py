#!/usr/bin/python3.7
from bs4 import BeautifulSoup as BS
import urllib.request, urllib.error, sys, ssl
#import mysql_write

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
                tgl_buat = soup.find_all('td')[tmp].get_text()
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
                
        tmp1, tmp2 = soup.find_all('td')[len(soup.find_all('td'))-1].get_text().split() #hapus kata peserta, ambil angkanya, selalu paling bawah kyknya
        jml_peserta = tmp1
        
        result_pengumuman = [kode_lelang, nama, tgl_buat, tahap, instansi, satker, kategori, thn_angg, pagu, hps, kualifikasi, jml_peserta]
        
        return result_pengumuman

def getData_Peserta(retry_limit, link, kode_lelang):
    soup = None
    linkGet = False
    result_peserta = []
    
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
            
            if soup.find_all('td')[i+2].get_text().startswith("Rp"):
                penawaran = soup.find_all('td')[i+2].get_text()
            else:
                penawaran = ""
            
            if soup.find_all('td')[i+3].get_text().startswith("Rp"):
                terkoreksi = soup.find_all('td')[i+3].get_text()
            else:
                terkoreksi = ""
            
            result_peserta.append([kode_lelang, nama, npwp, penawaran, terkoreksi]) #ganti fungsi biar masuk ke tabel
            
            i += 5
            
    return result_peserta
         
def getData_Evaluasi(retry_limit, link, kode_lelang):
    soup = None
    linkGet = False
    result_evaluasi = []
    
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
            
            result_evaluasi.append([kode_lelang, npwp, k, a, t, penawaran, terkoreksi, h, p, pk, alasan]) #ganti fungsi biar masuk ke tabel
            
    return result_evaluasi
            
def getData_Tahap(retry_limit, link, kode_lelang):
    soup = None
    linkGet = False
    result_tahap = []
    
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
            
            result_tahap.append([kode_lelang, tahap, mulai, sampai]) #ganti fungsi biar masuk ke tabel

    return result_tahap       
            
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
            
            result_pemenang = [kode_lelang, npwp]
            return result_pemenang
            
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
                        
            result_pemenang = [kode_lelang, npwp]
            return result_pemenang
            
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
            
            result_pemenangdetail = [npwp, nama, alamat]
            return result_pemenangdetail
            
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
                        
            result_pemenangdetail = [npwp, nama, alamat]
            return result_pemenangdetail
                
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
    
    server = str(sys.argv[6])
    port = str(sys.argv[7])
    db = str(sys.argv[8])
    user = str(sys.argv[9])
    pw = str(sys.argv[10])
    
    #mulai dari start sampai end, input dari UI
    for run in range(start_point, end_point+1): #i=start_point;i<end_point+1;i++
        kode_lelang = str(run) + lpse_code
        
        result_pengumuman = getData_Pengumuman(retry_limit, link, kode_lelang) #tabel lelang, a[x1, x2, ...., x12]
        result_peserta = getData_Peserta(retry_limit, link, kode_lelang) #tabel peserta, a[x][y]
        result_tahap = getData_Tahap(retry_limit, link, kode_lelang) #tabel tahap, a[x][y]
        result_evaluasi = getData_Evaluasi(retry_limit, link, kode_lelang) #tabel evaluasi, a[x][y]
        result_pemenang = getData_Pemenang(retry_limit, link, kode_lelang) #tabel pemenang, a[x1, x2]
        result_pemenangdetail = getData_PemenangDetail(retry_limit, link, kode_lelang) #tabel pemenang_detail, a[x1, x2, x3]
        
        #mysql_write.gatherData(server, port, db, user, pw, result_pengumuman, result_peserta, result_tahap, result_evaluasi, result_pemenang, result_pemenangdetail)