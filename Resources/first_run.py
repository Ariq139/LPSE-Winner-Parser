#!/usr/bin/python3.7
import mysql.connector, sys

def writeData(usr, pw, srv, db, port):
    cnx = mysql.connector.connect(user=usr, password=pw, host=srv)
    cursor = cnx.cursor()
    
    db_create = ("CREATE DATABASE IF NOT EXISTS "+db);
    
    cursor.execute(db_create)
    
    cnx.commit()
    
    table_create = ("CREATE TABLE IF NOT EXISTS `"+db+"`.`lelang` (`ID` varchar(8), `Nama Lelang` varchar(255), `Tipe` varchar(64), `Instansi` varchar(64), `Pemenang` varchar(255))")
    
    cursor.execute(table_create)
    
    add_entry = ("INSERT INTO "+loc_+" VALUES (%s, %s, %s, %s, %s)")
    entry_data = (id, name, type, instance, winner)
    
    cursor.execute(add_entry, entry_data)
    
    cnx.commit()

    cursor.close()
    cnx.close()

if __name__ == "__main__":
    init(usr, pw, srv, db, port)