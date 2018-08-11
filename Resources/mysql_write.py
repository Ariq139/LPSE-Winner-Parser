#!/usr/bin/python3.7
import mysql.connector, sys

def DBConnect(server, port, db, user, pw):
    cnx = mysql.connector.connect(user=user, password=pw, host=server, database=db, port=port)
    
    return cnx

    
#def gatherData(server, port, db, user, pw, result_pengumuman, result_peserta, result_tahap, result_evaluasi, result_pemenang, result_pemenangdetail):
def gatherData(server, port, db, user, pw, result_pengumuman, result_peserta, result_tahap, result_pemenang, result_pemenangdetail):
    
    cnx = DBConnect(server, port, db, user, pw)
    
    insertData_Pengumuman(cnx, result_pengumuman)
    insertData_Peserta(cnx, result_peserta)
    insertData_Tahap(cnx, result_tahap)
    #insertData_Evaluasi(cnx, result_evaluasi)
    insertData_Pemenang(cnx, result_pemenang)
    insertData_PemenangDetail(cnx, result_pemenangdetail)

    cnx.close()

    
def insertData_Pengumuman(cnx, result_pengumuman):
    cursor = cnx.cursor()
    
    add_entry = ("INSERT INTO pengumuman (`id_lelang`, `nama_lelang`, `tgl_buat`, `tahap`, `instansi`, `satker`, `kategori`, `thn_anggaran`, `pagu`, `hps`, `jml_peserta`) VALUES (%s, %s, %s, %s, %s, %s, %s, %s, %s, %s, %s)")
    entry_data = (result_pengumuman[0], result_pengumuman[1], result_pengumuman[2], result_pengumuman[3], result_pengumuman[4], result_pengumuman[5], result_pengumuman[6], result_pengumuman[7], result_pengumuman[8], result_pengumuman[9], result_pengumuman[10]) #kode_lelang, nama, tgl_buat, tahap, instansi, satker, kategori, thn_angg, pagu, hps, kualifikasi, jml_peserta
    
    try:
        cursor.execute(add_entry, entry_data)
    
        cnx.commit()
        
    except mysql.connector.Error as err:
        print(format(err), " ( Pengumuman )")
     
def insertData_Peserta(cnx, result_peserta):
    cursor = cnx.cursor()
    
    for i in range(len(result_peserta)):
        add_entry = ("INSERT INTO peserta VALUES (%s, %s, %s, %s, %s)")
        entry_data = (result_peserta[i][0], result_peserta[i][1], result_peserta[i][2], result_peserta[i][3], result_peserta[i][4]) #kode_lelang, nama, npwp, penawaran, terkoreksi
    
        try:
            cursor.execute(add_entry, entry_data)
    
            cnx.commit()
            
        except mysql.connector.Error as err:
            print(format(err), " ( Peserta )")
     
def insertData_Tahap(cnx, result_tahap):
    cursor = cnx.cursor()
    
    for i in range(len(result_tahap)):
        add_entry = ("INSERT INTO tahap VALUES (%s, %s, %s, %s)")
        entry_data = (result_tahap[i][0], result_tahap[i][1], result_tahap[i][2], result_tahap[i][3]) #kode_lelang, tahap, mulai, sampai
    
        try:
            cursor.execute(add_entry, entry_data)
    
            cnx.commit()
            
        except mysql.connector.Error as err:
            print(format(err), " ( Tahap )")

"""
def insertData_Evaluasi(cnx, result_evaluasi):
    cursor = cnx.cursor()
    
    for i in range(len(result_evaluasi)):
        add_entry = ("INSERT INTO evaluasi VALUES (%s, %s, %s, %s, %s, %s, %s, %s, %s, %s, %s)")
        entry_data = (result_evaluasi[i][0], result_evaluasi[i][1], result_evaluasi[i][2], result_evaluasi[i][3], result_evaluasi[i][4], result_evaluasi[i][5], result_evaluasi[i][6], result_evaluasi[i][7], result_evaluasi[i][8], result_evaluasi[i][9], result_evaluasi[i][10]) #kode_lelang, npwp, k, a, t, penawaran, terkoreksi, h, p, pk, alasan
    
        try:
            cursor.execute(add_entry, entry_data)
    
            cnx.commit()
        
        except mysql.connector.Error as err:
            print(format(err), " ( Evaluasi )")
"""
        
def insertData_Pemenang(cnx, result_pemenang):
    cursor = cnx.cursor()
    
    add_entry = ("INSERT INTO pemenang VALUES (%s, %s)")
    entry_data = (result_pemenang[0], result_pemenang[1]) #kode_lelang, npwp
    
    try:
        cursor.execute(add_entry, entry_data)
    
        cnx.commit()
        
    except mysql.connector.Error as err:
        print(format(err), " ( Pemenang )")
        
def insertData_PemenangDetail(cnx, result_pemenangdetail):
    cursor = cnx.cursor()
    
    add_entry = ("INSERT INTO pemenang_detail VALUES (%s, %s, %s)")
    entry_data = (result_pemenangdetail[0], result_pemenangdetail[1], result_pemenangdetail[2]) #npwp, nama, alamat
    
    try:
        cursor.execute(add_entry, entry_data)
    
        cnx.commit()
        
    except mysql.connector.Error as err:
        if err.errno == 1062: #duplicate primary
            pass #biarkan
        else:
            print(format(err), " ( PemenangDetail )")
 
if __name__ == "__main__":
    server = str(sys.argv[1])
    port = str(sys.argv[2])
    db = str(sys.argv[3])
    user = str(sys.argv[4])
    pw = str(sys.argv[5])
    
    result_pengumuman = sys.argv[6]
    result_peserta = sys.argv[7]
    result_tahap = sys.argv[8]
    #result_evaluasi = sys.argv[9]
    result_pemenang = sys.argv[9]
    result_pemenangdetail = sys.argv[10]

    gatherData(server, port, db, user, pw, result_pengumuman, result_peserta, result_tahap, result_pemenang, result_pemenangdetail)