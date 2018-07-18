#!/usr/bin/python3.7
import mysql.connector, sys

def writeData(usr, pw, srv, db, id, name, type, instance, winner, loc_):
    cnx = mysql.connector.connect(user=usr, password=pw,
                              host=srv,
                              database=db)
    cursor = cnx.cursor()
    
    table_create = ("CREATE TABLE IF NOT EXISTS `"+db+"`.`"+loc_+"` (`ID` varchar(8), `Nama Lelang` varchar(255), `Tipe` varchar(64), `Instansi` varchar(64), `Pemenang` varchar(255))")
    
    add_entry = ("INSERT INTO "+loc_+" VALUES (%s, %s, %s, %s, %s)")
    entry_data = (id, name, type, instance, winner)
    
    cursor.execute(add_entry, entry_data)
    
    cnx.commit()

    cursor.close()
    cnx.close()

if __name__ == "__main__":
    usr = str(sys.argv[1])
    pw = str(sys.argv[2])
    srv = str(sys.argv[3])
    db = str(sys.argv[4])
    id = str(sys.argv[5])
    name = str(sys.argv[6])
    type = str(sys.argv[7])
    instance = str(sys.argv[8])
    winner = str(sys.argv[9])
    loc_ = str(sys.argv[10])
    
    writeData(usr, pw, srv, db, id, name, type, instance, winner, loc_)