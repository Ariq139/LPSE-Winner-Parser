# LPSE Winner Parser
## Runtime Requirement
1. Python 3.7
   - BeautifulSoup4 `py -3.7 -m pip install beautifulsoup4`
   - MySQL Connector `py -3.7 -m pip install mysql-connector-python`
2. .NET Framework 4.7
3. XAMPP + MySQL / DB MySQL
4. [Java 8](https://java.com/en/download/)
5. [Gephi](https://gephi.org/users/download/) (Untuk format .gexf)
   - [Gephi Toolkit](https://gephi.org/toolkit/) (Tempatkan di Resources/lib)
6. Internet kencang (Untuk Crawler)

## Cara memasukkan data ke database dengan Crawler
1. Login ke database. Jika belum ada, masukkan nama database dan klik Create
2. Klik Data di kiri atas, lalu Crawler
3. Pilih LPSE, start point, end point, dan retry

#### CONTOH
```
Tempat = LPSE Universitas Gadjah Mada
Start Point = 1
End Point = 1200
Max. Retry = 3
```
> Artinya, ambil data dari website LPSE UGM, dari ID 1303 sampai 1200303, kalau ada masalah saat mencoba connect ke website, ulang sampai 3 kali.

### NOTE
1. Jika ada error 500/403/404 di console, tolong diabaikan
2. Console tidak sepenuhnya terupdate real time
3. Tidak ada data Evaluasi, karena terlalu inkonsisten
4. Jika internet terlalu lambat, script akan hang tanpa error. Salah satu caranya adalah dengan restart aplikasi, karena sulit didebug.
5. Ada sample data yang tersedia untuk contoh, dengan pilih Data, lalu Import sample data

## Cara export graph dari data
1. Pilih tab Graph/Network
2. Pilih sumber data. Pilihan Leaderboard adalah pilihan untuk membuat graph dari Leaderboard di bagian kanan aplikasi
3. Ganti option bila perlu
4. Klik "Start"

### NOTE
1. Repulsion adalah kekuatan node menjauhi node lain yang tidak terhubung
2. Waktu lebih banyak + repulsion tinggi = Makin jauh jarak antar node yang tidak berhubungan
3. Color harus dalam bentuk hex dengan tambahan "0x" dan pakai format RGB, contoh: `255,0,0 diubah menjadi 0xFF0000`
