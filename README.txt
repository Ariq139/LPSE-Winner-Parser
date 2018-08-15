/////////////////////////////////////////////////////////////////
Development Requirement

1. Visual Studio 2017
2. Python 3.7
   - BeautifulSoup4 (py -3.7 -m pip install beautifulsoup4)
   - MySQL Connector (py -3.7 -m pip install mysql-connector-python)
3. .NET Framework 4.7
4. XAMPP + MySQL / DB MySQL
5. Java 8
6. Gephi (Untuk format .gexf)
   - Gephi Toolkit (Tempatkan di Resources/lib)
7. Internet kencang (Untuk Crawler)
/////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////
Cara memasukkan data ke database dengan Crawler

1. Login ke database. Jika belum ada, masukkan nama database dan klik Create. Program akan membuatkan databasenya dan juga tabel-tabelnya.
2. Klik Data di kiri atas, lalu Crawler.
3. Pilih LPSE, start point, end point, dan max. retry.

CONTOH:
Tempat = LPSE Universitas Gadjah Mada
Start Point = 1
End Point = 1200
Max. Retry = 3

Artinya, ambil data dari website LPSE UGM, dari ID 1303 sampai 1200303, kalau ada masalah saat mencoba connect ke website, ulang sampai 3 kali.

NOTE
1. Program mengasumsi pengguna sudah punya username dan password untuk akses ke server database.
2. Jika ada error 500/403/404 di console, tolong diabaikan karena itu normal.
3. Console tidak sepenuhnya terupdate real time.
4. Tidak ada data Evaluasi, karena terlalu inkonsisten.
5. Jika internet terlalu lambat, ditengah jalan script akan hang tanpa error. Salah satu cara mengatasinya adalah dengan restart aplikasi, karena sulit didebug.
6. Daftar LPSE hardcoded, karena website daftar semua LPSE tidak bisa dibaca oleh script.
/////////////////////////////////////////////////////////////////

/////////////////////////////////////////////////////////////////
Cara export graph dari data

1. Pilih tab Graph/Network
2. Pilih sumber data. Pilihan Leaderboard adalah pilihan untuk membuat graph dari Leaderboard di bagian kanan aplikasi
3. Ganti option bila perlu
4. Klik "Start"

NOTE
1. Repulsion adalah kekuatan node menjauhi node lain yang tidak terhubung
2. Waktu lebih banyak + repulsion tinggi = Makin jauh jarak antar node yang tidak berhubungan
3. Color harus dalam bentuk hex dengan tambahan "0x" dan pakai format RGB, contoh: 255,0,0 diubah menjadi 0xFF0000
4. Data Leaderboard tidak bisa dibatasi karena MariaDB tidak support penggunaan LIMIT dalam subquery IN (), sehingga data terlalu banyak.
/////////////////////////////////////////////////////////////////
