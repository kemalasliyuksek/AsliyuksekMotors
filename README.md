# ASLIYÜKSEK MOTORS ARAÇ KİRALAMA VE SATIŞ OTOMASYONU PROJESİ

## BENİM HAKKIMDA

Ad Soyad: KEMAL ASLIYÜKSEK

Bölüm: Bilgisayar Programcılığı

## BİLGİLENDİRME

*Not: Bu proje şu anda sadece SİSTEM ANALİZİ VE TASARIMI dersi için
oluşturulmaktadır. Daha sonrasında tarafımca (KEMAL ASLIYÜKSEK)
geliştirilip somut bir proje amacıyla geliştirilecektir.*

## İÇİNDEKİLER

1. Yönetici Özeti
2. Projenin Amacı ve Kapsamı
3. Sistem Mimarisi
4. Masaüstü Uygulaması
5. Web Sitesi Uygulaması
6. Veri Yapısı ve Yönetimi
7. UML Diyagramları
8. Arayüz Tasarım Taslakları
9. Teknik Gereksinimler
10. Proje Zaman Planı
11. Test Stratejisi
12. Riskler ve Çözüm Önerileri
13. Güvenlik Önlemleri
14. Bütçe Tahmini
15. Beklenen Faydalar
16. Geliştirme ve İlerleme Planı

## 1. YÖNETİCİ ÖZETİ

Bu rapor, şirketlerin araç kiralama ve satış süreçlerini modernize etmek
ve dijitalleştirmek amacıyla geliştirmeyi planladığım otomasyon
projesine ilişkin kapsamlı bir bakış sunmaktadır. Proje, iki ana
bileşenden oluşmaktadır: şirket çalışanları tarafından kullanılacak
kapsamlı bir masaüstü uygulaması ve müşterilerin online işlem
yapabilmelerini sağlayacak modern bir web sitesi.

Bu entegre sistem sayesinde araç envanterinin yönetimi, kiralama ve
satış işlemlerinin takibi, müşteri ilişkilerinin yönetimi ve finansal
raporlama süreçlerinin tek bir platform üzerinden yönetilmesi
hedeflenmektedir. Ayrıca, müşterilere sunulan hizmet kalitesinin
artırılması, operasyonel verimliliğin yükseltilmesi ve şirket
gelirlerinin optimize edilmesi amaçlanmaktadır.

Projemizin temel hedefi manuel süreçleri otomatikleştirerek, hata oranlarını düşürmek, iş süreçlerini hızlandırmak ve veriye dayalı karar verme imkanı sunmaktır. Araç kiralama ve satış alanında rekabet avantajı sağlayacak bu sistem, aşamalı olarak geliştirilecek ve ileride ek özelliklerle zenginleştirilecektir.

## 2. PROJENİN AMACI VE KAPSAMI

### Amaç

Proje, araç kiralama ve satış operasyonlarını bütünleşik bir dijital platform üzerinde toplama, süreçleri standartlaştırma, verimliliği artırma ve müşteri deneyimini iyileştirme amacını taşımaktadır. Bu amaçla geliştirilen sistem sayesinde:

- Araç kiralama ve satış süreçlerinin standardizasyonu
- İş süreçlerinde verimliliğin artırılması
- Müşteri memnuniyetinin yükseltilmesi
- Karar verme süreçlerinde veri analitiğinin kullanılması
- Operasyonel maliyetlerin azaltılması
- Dijital dönüşümün sağlanması

hedeflenmektedir.

### Kapsamı

Proje iki temel bileşenden oluşmaktadır:

1. **Masaüstü Uygulaması (İç Kullanım):** Şirket çalışanları tarafından
   kullanılacak, tüm iş süreçlerini kapsayan ve operasyonel yönetimin
   merkezi olan uygulama.

2. **Web Sitesi Uygulaması (Müşteri Arayüzü):** Müşterilerin online
   olarak araçları görüntüleyebileceği, kiralama yapabileceği ve şirket
   ile iletişim kurabileceği platform.

Bu iki bileşen gerçek zamanlı veri senkronizasyonu ile birlikte
çalışarak bütünleşik bir sistem oluşturacaktır.

### Kapsam Dışı Bırakılan Özellikler

Gelecek aşamalarda geliştirilmek üzere şu an için planlanan sistem kapsamı dışında bırakılan özellikler:
- Mobil uygulama
- Muhasebe yazılımları ile tam entegrasyon
- Gelişmiş CRM özellikleri
- Tam kapsamlı iş zekası ve analitik araçları
- GPS ve araç takip sistemleri entegrasyonu

## 3. SİSTEM MİMARİSİ

### Genel Mimari

Sistem, istemci-sunucu mimarisi üzerine kurulacaktır:

1. **Veritabanı Katmanı:** Sistemin tüm verilerinin depolandığı merkezi
   veritabanı
2. **Uygulama Sunucu Katmanı:** İş mantığını yürüten ve veritabanı ile
   iletişim kuran katman
3. **İstemci Katmanı:** Masaüstü uygulaması ve web sitesi arayüzleri

### Teknoloji Seçimleri

1. **Masaüstü Uygulaması:**
   - Programlama Dili: C# (.NET Framework)
   - Arayüz: Windows Forms
   - ORM: Entity Framework
   - Raporlama: Crystal Reports veya Microsoft Reporting Services

2. **Web Sitesi:**
   - Frontend: HTML5, CSS3, JavaScript, Bootstrap
   - Backend: ASP.NET MVC veya PHP Laravel (Değişebilir)
   - JavaScript Framework: jQuery ve/veya React
   - Responsive Design: Bootstrap

3. **Veritabanı:**
   - MySQL veya MSSQL
   - Veri Erişim Katmanı: ADO.NET ve LINQ

4. **Entegrasyon:**
   - RESTful API
   - JSON veri formatı
   - HTTPS protokolü

### Sistem Mimarisi Diyagramı

```
+-----------------------+       +------------------------+
|                       |       |                        |
|  Masaüstü Uygulaması  |       |    Web Uygulaması      |
|  (Windows Forms)      |       |    (ASP.NET/PHP)       |
|                       |       |                        |
+-----------+-----------+       +------------+-----------+
            |                                |
            |                                |
            v                                v
+------------------------------------------------------+
|                                                      |
|                  API Katmanı (REST)                  |
|                                                      |
+------------------------------------------------------+
                          |
                          |
                          v
+------------------------------------------------------+
|                                                      |
|              İş Mantığı Katmanı (C#)                 |
|                                                      |
+------------------------------------------------------+
                          |
                          |
                          v
+------------------------------------------------------+
|                                                      |
|               Veri Erişim Katmanı                    |
|               (Entity Framework)                     |
|                                                      |
+------------------------------------------------------+
                          |
                          |
                          v
+------------------------------------------------------+
|                                                      |
|             Veritabanı (MySQL/MSSQL)                 |
|                                                      |
+------------------------------------------------------+
```

### Çalışma Prensibi

1. İstemci (masaüstü veya web), API katmanına HTTP istekleri gönderir
2. API katmanı, isteği işler ve iş mantığı katmanına yönlendirir
3. İş mantığı katmanı, gerekli işlemleri yapar ve veri erişim katmanını kullanarak veritabanı işlemlerini gerçekleştirir
4. Sonuçlar, aynı yoldan geriye doğru iletilir ve kullanıcıya gösterilir
5. Gerçek zamanlı veri senkronizasyonu, API katmanı aracılığıyla sağlanır

## 4. MASAÜSTÜ UYGULAMASI

### Kullanıcı Yönetimi

- Rol tabanlı yetkilendirme sistemi (Yönetici, Satış Temsilcisi, Finans Sorumlusu vb.)
- Güvenli giriş sistemi ve şifre politikaları
- Kullanıcı eylemlerinin kayıt altına alınması (log)
- Personel performans izleme
- Yetki grupları ve özel izinler tanımlama
- Şifre sıfırlama ve kullanıcı hesabı askıya alma

### Araç Yönetimi

- Araç envanteri ve detaylı araç bilgileri (marka, model, motor, şasi, plaka, vb.)
- Araç durumu takibi (satılık, kiralık, kiralanmış, bakımda, vb.)
- Araç bakım ve servis takibi
- Araç belgeleri ve dokümanlarının dijital arşivlenmesi
- Araç alım-satım işlemleri ve geçmişi
- Çoklu fotoğraf ve belge yükleme
- Araç kategorileri ve sınıflandırma
- Araç maliyetleri ve kârlılık analizi
- Araç konumları ve şubeler arası transfer

### Müşteri Yönetimi

- Müşteri bilgileri ve profil yönetimi
- Müşteri iletişim geçmişi takibi
- Müşteri kiralama ve satın alma geçmişi
- Potansiyel müşteri (lead) takibi ve CRM özellikleri (ileri seviyede)
- Müşteri segmentasyonu ve özel kampanya yönetimi
- Kara liste yönetimi
- Ehliyet ve kimlik dokümanları arşivleme
- Hatırlatma ve bildirim sistemi

### Kiralama İşlemleri

- Kiralama sözleşmesi oluşturma ve çıktı alma
- Tarih bazlı araç müsaitlik kontrolü
- Dinamik fiyatlandırma ve özel fiyat uygulamaları
- Ek hizmet ve ekipman yönetimi
- Araç teslim ve iade işlemleri
- Hasar ve kaza raporları
- Kiralama uzatma ve değişiklik yönetimi
- Gecikme bildirimleri ve ceza yönetimi
- Kiralama takvimi görünümü
- Araç yedekleme ve alternatif öneri

### Satış İşlemleri

- Satış sözleşmesi oluşturma
- Ödeme planı ve taksit takibi
- Araç devir ve teslim işlemleri
- Garanti ve servis paketleri yönetimi
- Araç değerleme ve fiyatlandırma
- İkinci el araç alım-satım işlemleri
- Satış hedefleri ve performans takibi
- Komisyon hesaplama

### Finans Yönetimi

- Tahsilat ve ödeme kayıtları
- Gelir-gider yönetimi ve nakit akışı
- Fatura oluşturma ve yönetimi
- Vergi hesaplamaları ve mevzuat uyumu
- Finansal raporlar ve analizler
- Kasa ve banka hesapları takibi
- Borç-alacak takibi
- Kâr-zarar analizi

> *Not: Finans Yönetimi için destek alınabilir veya ilk süreçte olması
> gerekenden daha basit bir şekilde oluşturulup ileri seviyede
> geliştirilerek daha iyi bir hale getirilebilir.*

### Raporlama Sistemi

- Dinamik rapor oluşturma
- Grafiksel analiz ve göstergeler
- Excel/PDF çıktıları
- KPI takibi ve performans ölçümleri
- Özelleştirilebilir raporlar
- Periyodik otomatik rapor oluşturma
- Çapraz tablolar ve pivot analizler
- Trend analizleri ve tahminleme

## 5. WEB SİTESİ UYGULAMASI

### Ana Sayfa

- Öne çıkan araçlar ve özel teklifler
- Hızlı arama fonksiyonu
- Kampanya duyuruları ve sliderlar
- Marka tanıtımı ve değer önerisi
- Mobil uyumlu tasarım
- Hızlı erişim menüleri

### Araç Listeleme ve Arama

- Detaylı filtreleme seçenekleri
- Araç karşılaştırma
- Kapsamlı araç bilgileri ve görseller
- 360° araç görüntüleme (opsiyonel)
- Listeyi kaydetme ve bildirim alma
- Benzer araç önerileri
- Fiyat değişimi takibi

### Online Rezervasyon Sistemi

- Tarih ve lokasyon seçimi
- Gerçek zamanlı müsaitlik kontrolü
- Fiyat hesaplama ve ek hizmet seçimleri
- Ödeme entegrasyonu (ileri seviye)
- Rezervasyon onay süreci
- Sözleşme önizleme
- Rezervasyon değişikliği ve iptali
- E-posta ve SMS bildirimler

### Müşteri Hesapları

- Kayıt ve giriş sistemi
- Profil yönetimi
- Rezervasyon geçmişi ve durum takibi
- Fatura ve belge erişimi
- Kişiselleştirilmiş teklifler
- Çoklu rezervasyon yönetimi
- Favorilere ekleme
- Sadakat programı ve puanlar (ileri seviye)

### İletişim ve Destek

- İletişim formu ve şube bilgileri
- Sıkça sorulan sorular
- Canlı destek (opsiyonel)
- Geri bildirim sistemi
- Harita entegrasyonu
- Şube çalışma saatleri
- Acil durum iletişim bilgileri

### Blog ve İçerik Yönetimi

- Sektör haberleri ve bilgilendirici içerikler
- Seyahat ve araç bakım önerileri
- SEO optimizasyonu (ileri seviyede)
- Sosyal medya entegrasyonu
- İçerik kategorileri
- Popüler ve önerilen içerikler
- Kullanıcı yorumları

## 6. VERİ YAPISI VE YÖNETİMİ

### Veritabanı Şeması

Sistemin ana veri tabloları aşağıdaki gibi olacaktır:

- **Araçlar:** Tüm araç bilgileri ve özellikleri
  - AracID, Plaka, Marka, Model, YapimYili, MotorNo, SasiNo, Renk, Kilometre, YakitTipi, VitesTipi, DurumID, AlinmaTarihi, AlisFiyati, SatisFiyati, KiraFiyati, AracSinifi, SubeID

- **Müşteriler:** Müşteri bilgileri ve iletişim detayları
  - MusteriID, Ad, Soyad, TC, DogumTarihi, EhliyetNo, EhliyetSinifi, EhliyetTarihi, TelefonNo, Email, Adres, KayitTarihi, MusaitlikDurumu, MusteriTipi

- **Kullanıcılar:** Sistem çalışanları ve yetkileri
  - KullaniciID, Ad, Soyad, KullaniciAdi, Sifre, Email, Telefon, RolID, SubeID, SonGirisTarihi, Durum

- **Kiralamalar:** Kiralama işlemleri ve detayları
  - KiralamaID, MusteriID, AracID, BaslangicTarihi, BitisTarihi, TeslimTarihi, BaslangicKm, BitisTm, KiralamaTutari, DepozitTutari, OdemeTipi, KiralamaNotuID, SozlesmeID, KullaniciID

- **Satışlar:** Satış işlemleri ve detayları
  - SatisID, MusteriID, AracID, SatisTarihi, SatisTutari, OdemeTipi, TaksitSayisi, NoterTarihi, SozlesmeID, KullaniciID

- **Ödemeler:** Tüm finansal işlemler
  - OdemeID, IslemTipi, IslemID, MusteriID, Tutar, OdemeTarihi, OdemeTipi, BankaID, OdemeNot, KullaniciID

- **Bakımlar:** Araç bakım ve servis kayıtları
  - BakimID, AracID, BaslamaTarihi, BitisTarihi, BakimTipi, BakimNotu, Maliyet, ServisID, KullaniciID

- **Belgeler:** Dijital belgeler ve dosyalar
  - BelgeID, IslemTipi, IslemID, BelgeTipi, DosyaYolu, YuklemeTarihi, KullaniciID

- **Loglar:** Sistem aktivite kayıtları
  - LogID, KullaniciID, IslemTipi, IslemDetayi, IPAdresi, IslemTarihi

### İlişkisel Veri Modeli

```
Araçlar <---> Kiralamalar <---> Müşteriler
   ^              ^                ^
   |              |                |
   v              v                v
Bakımlar        Ödemeler         Belgeler
   ^              ^                ^
   |              |                |
   +-----> Satışlar <--------------+
              ^
              |
              v
         Kullanıcılar <---> Loglar
```

### Veri Güvenliği

- Rol bazlı erişim kontrolü
- Veri şifreleme
- Düzenli yedekleme
- KVKK uyumlu veri saklama ve işleme (ileri seviyede)
- Güvenlik duvarı ve penetrasyon testleri (ileri seviyede)
- Hassas verilerin maskelenmesi
- Oturum zaman aşımı ve güvenli çıkış
- İşlem log kayıtları

### Veri Entegrasyonu

- Masaüstü ve web uygulamaları arasında gerçek zamanlı senkronizasyon
- API tabanlı veri alışverişi
- Ödeme sistemleri entegrasyonu (ileri seviyede)
- SMS ve e-posta servisleri entegrasyonu (ileri seviyede)
- Veri tutarlılığı kontrolü
- Cache mekanizması ile performans optimizasyonu

## 7. UML DİYAGRAMLARI

### Kullanım Durumu (Use Case) Diyagramı

```
+----------------------------------------------------------------+
|                     Araç Kiralama Sistemi                      |
|                                                                |
|  +----------------+        +----------------------------+      |
|  |                |        |                            |      |
|  |   Yönetici     |------->|   Kullanıcı Yönetimi      |      |
|  |                |        |                            |      |
|  +----------------+        +----------------------------+      |
|          |                                                     |
|          |                 +----------------------------+      |
|          |                 |                            |      |
|          +---------------->|   Araç Yönetimi           |      |
|          |                 |                            |      |
|          |                 +----------------------------+      |
|          |                                                     |
|          |                 +----------------------------+      |
|          |                 |                            |      |
|          +---------------->|   Raporlar                |      |
|                            |                            |      |
|                            +----------------------------+      |
|                                                                |
|  +----------------+        +----------------------------+      |
|  |                |        |                            |      |
|  |  Satış Personeli|------->|   Müşteri Yönetimi        |      |
|  |                |        |                            |      |
|  +----------------+        +----------------------------+      |
|          |                                                     |
|          |                 +----------------------------+      |
|          |                 |                            |      |
|          +---------------->|   Kiralama İşlemleri      |      |
|          |                 |                            |      |
|          |                 +----------------------------+      |
|          |                                                     |
|          |                 +----------------------------+      |
|          |                 |                            |      |
|          +---------------->|   Satış İşlemleri         |      |
|                            |                            |      |
|                            +----------------------------+      |
|                                                                |
|  +----------------+        +----------------------------+      |
|  |                |        |                            |      |
|  |    Müşteri     |------->|   Araçları Görüntüleme    |      |
|  |                |        |                            |      |
|  +----------------+        +----------------------------+      |
|          |                                                     |
|          |                 +----------------------------+      |
|          |                 |                            |      |
|          +---------------->|   Rezervasyon Yapma        |      |
|          |                 |                            |      |
|          |                 +----------------------------+      |
|          |                                                     |
|          |                 +----------------------------+      |
|          |                 |                            |      |
|          +---------------->|   Hesap Yönetimi          |      |
|                            |                            |      |
|                            +----------------------------+      |
|                                                                |
+----------------------------------------------------------------+
```

### Sınıf (Class) Diyagramı (Basitleştirilmiş)

```
+---------------+      +---------------+       +---------------+
|    Araç       |      |   Kiralama    |       |   Müşteri     |
+---------------+      +---------------+       +---------------+
| - AracID      |      | - KiralamaID  |       | - MusteriID   |
| - Plaka       |<>----| - AracID      |------>| - Ad          |
| - Marka       |      | - MusteriID   |       | - Soyad       |
| - Model       |      | - BaslangicT  |       | - TC          |
| - YapimYili   |      | - BitisT      |       | - EhliyetNo   |
| - MotorNo     |      | - Tutar       |       | - Telefon     |
| - SasiNo      |      | - Durum       |       | - Email       |
| - Durum       |      +---------------+       +---------------+
+---------------+              |                      ^
        ^                      |                      |
        |                      |                      |
+---------------+      +---------------+       +---------------+
|    Satış      |      |   Ödeme       |       |   Belge       |
+---------------+      +---------------+       +---------------+
| - SatisID     |      | - OdemeID     |       | - BelgeID     |
| - AracID      |<>----| - IslemTipi   |       | - IslemTipi   |
| - MusteriID   |      | - IslemID     |------>| - IslemID     |
| - SatisTarihi |      | - Tutar       |       | - DosyaYolu   |
| - Tutar       |      | - OdemeTipi   |       | - YuklemeTarihi|
| - OdemeTipi   |      +---------------+       +---------------+
+---------------+
```

### Aktivite (Activity) Diyagramı: Kiralama Süreci

```
        +---------------+
        |   Başla       |
        +-------+-------+
                |
                v
        +---------------+
        | Araç Seçimi   |
        +-------+-------+
                |
                v
        +---------------+
        | Müsaitlik     |
        | Kontrolü      |
        +-------+-------+
                |
                v
        +---------------+
     +--+ Müsait mi?    |
     |  +-------+-------+
     |          |
     |          | Evet
     |          v
     |  +---------------+
     |  | Müşteri Bilgi |
     |  | Girişi        |
     |  +-------+-------+
     |          |
     |          v
     |  +---------------+
     |  | Ek Hizmet     |
     |  | Seçimi        |
     |  +-------+-------+
     |          |
     |          v
     |  +---------------+
     |  | Fiyat         |
     |  | Hesaplama     |
     |  +-------+-------+
     |          |
     |          v
     |  +---------------+
     |  | Sözleşme      |
     |  | Oluşturma     |
     |  +-------+-------+
     |          |
     |          v
     |  +---------------+
     |  | Ödeme         |
     |  | Alma          |
     |  +-------+-------+
     |          |
     |          v
     |  +---------------+
     |  | Araç Teslimi  |
     |  +-------+-------+
     |          |
     |          v
     |  +---------------+
     |  |   Bitir       |
     |  +---------------+
     |
     | Hayır
     v
+---------------+
| Alternatif    |
| Araç Önerisi  |
+-------+-------+
        |
        +------->
```

### Ardışıl (Sequence) Diyagramı: Web Üzerinden Rezervasyon

```
    Müşteri         Web Sitesi        API         Veritabanı
       |                |               |             |
       |---Araç Arama-->|               |             |
       |                |--Araç Sorgusu>|             |
       |                |               |--Verileri Al>|
       |                |               |<--Sonuçlar--|
       |<--Araç Listesi-|<--Sonuçlar---|             |
       |                |               |             |
       |--Araç Seçimi-->|               |             |
       |                |--Müsaitlik--->|             |
       |                |               |--Kontrol Et>|
       |                |               |<--Durum-----|
       |<-Tarih Seçimi--|<--Durum------|             |
       |                |               |             |
       |--Bilgi Girişi->|               |             |
       |                |--Rezervasyon->|             |
       |                |               |--Kaydet---->|
       |                |               |<--Onay------|
       |<--Onay Kodu----|<--Onay-------|             |
       |                |               |             |
```

## 8. ARAYÜZ TASARIM TASLAKLARI

### Masaüstü Uygulaması

#### Ana Ekran (Dashboard)

```
+--------------------------------------------------------------+
|  Logo   | Araç Yönetimi | Müşteriler | Kiralamalar | Satış  |
+--------------------------------------------------------------+
|                                                              |
|  +--------------------+      +------------------------+      |
|  |  Aktif Kiralamalar |      |  Araç Durumu          |      |
|  |  ---------------   |      |  ---------------       |      |
|  |  5 Kiralama        |      |  15 Müsait            |      |
|  |  3 Bugün Dönecek   |      |  22 Kiralanmış        |      |
|  |  2 Gecikmiş        |      |  4  Bakımda           |      |
|  +--------------------+      +------------------------+      |
|                                                              |
|  +--------------------+      +------------------------+      |
|  |  Bugünkü İşlemler  |      |  Finans Durumu        |      |
|  |  ---------------   |      |  ---------------       |      |
|  |  3 Yeni Kiralama   |      |  25.000 TL Gelir      |      |
|  |  2 İade            |      |  5.000 TL Gider       |      |
|  |  1 Satış           |      |  20.000 TL Net        |      |
|  +--------------------+      +------------------------+      |
|                                                              |
+--------------------------------------------------------------+
|  Kullanıcı: Admin     |    Tarih: 05.03.2025    |  Sürüm: 1.0  |
+--------------------------------------------------------------+
```

#### Araç Yönetimi Ekranı

```
+--------------------------------------------------------------+
|  Logo   | < Geri |  Araç Yönetimi                   | Çıkış |
+--------------------------------------------------------------+
|  + Yeni Araç | Düzenle | Sil | Bakım | Detay | Raporlar     |
+--------------------------------------------------------------+
|  Arama: [                                  ] | Filtrele ▼    |
+--------------------------------------------------------------+
|                                                              |
|  Plaka    | Marka  | Model | Yıl  | Durum    | Fiyat (G/A)  |
|  ---------|--------|-------|------|----------|------------- |
|  34AB1234 | Toyota | Corolla| 2022 | Müsait   | 850 TL/Gün   |
|  34CD5678 | Honda  | Civic | 2021 | Kiralamada| 800 TL/Gün   |
|  34EF9012 | BMW    | 320i  | 2023 | Bakımda  | 1200 TL/Gün  |
|  34GH3456 | Mercedes| C180 | 2022 | Müsait   | 1100 TL/Gün  |
|  34IJ7890 | Renault| Clio  | 2021 | Satılık  | 320,000 TL   |
|  34KL1234 | Ford   | Focus | 2020 | Müsait   | 750 TL/Gün   |
|  34MN5678 | Audi   | A3    | 2022 | Kiralamada| 950 TL/Gün   |
|                                                              |
+--------------------------------------------------------------+
|  Toplam: 15 Araç  |  Sayfa: 1/2  | < 1 2 > |                |
+--------------------------------------------------------------+
```

#### Kiralama İşlemi Ekranı

```
+--------------------------------------------------------------+
|  Logo   | < Geri |  Yeni Kiralama İşlemi             | Çıkış |
+--------------------------------------------------------------+
|                                                              |
|  +---------------------+      +-------------------------+    |
|  |                     |      | Müşteri Bilgileri      |    |
|  |                     |      | Adı: [            ]    |    |
|  |                     |      | Soyadı: [         ]    |    |
|  |    Araç Bilgileri   |      | TC: [              ]   |    |
|  |                     |      | Tel: [              ]  |    |
|  |    Resim Alanı      |      | Ehliyet: [          ]  |    |
|  |                     |      +-------------------------+    |
|  |                     |                                     |
|  +---------------------+      +-------------------------+    |
|                               | Kiralama Detayları     |    |
|  Plaka: [          ]          | Başlangıç: [DD/MM/YYYY]|    |
|  Marka: [          ]          | Bitiş: [DD/MM/YYYY]    |    |
|  Model: [          ]          | Süre: [ ] Gün          |    |
|  Yıl: [    ]                  | Ücret: [        ] TL   |    |
|  Yakıt: [         ]           | Depozito: [      ] TL  |    |
|  Vites: [         ]           | Ek Hizmetler [Seç ▼]   |    |
|                               +-------------------------+    |
|                                                              |
|  [Müşteri Seç] [Araç Seç] [Hesapla] [Belge Ekle] [Sözleşme] |
+--------------------------------------------------------------+
|  [   İptal   ]                               [   Kaydet    ] |
+--------------------------------------------------------------+
```

### Web Sitesi Taslakları

#### Ana Sayfa

```
+--------------------------------------------------------------+
|  LOGO   | ANASAYFA | ARAÇLAR | REZERVASYON | BLOG | İLETİŞİM |
+--------------------------------------------------------------+
|  [Üye Girişi]                               [0850 123 45 67] |
+--------------------------------------------------------------+
|                                                              |
|     +--------------------------------------------------+     |
|     |                                                  |     |
|     |                                                  |     |
|     |             SLIDER / BANNER ALANI                |     |
|     |                                                  |     |
|     |                                                  |     |
|     +--------------------------------------------------+     |
|                                                              |
|  +------------------------------------------------------+    |
|  |        ARAÇ KİRALAMA                                 |    |
|  |  Alış Yeri: [             ▼]  Tarih: [    ▼] [    ▼] |    |
|  |  İade Yeri: [             ▼]  Tarih: [    ▼] [    ▼] |    |
|  |                          [      ARA      ]           |    |
|  +------------------------------------------------------+    |
|                                                              |
|  +--------------+  +--------------+  +--------------+        |
|  | ARAÇ KATEGORİ|  | ARAÇ KATEGORİ|  | ARAÇ KATEGORİ|        |
|  |              |  |              |  |              |        |
|  |    Resim     |  |    Resim     |  |    Resim     |        |
|  |              |  |              |  |              |        |
|  |  Ekonomik    |  |  Konfor      |  |  Premium     |        |
|  +--------------+  +--------------+  +--------------+        |
|                                                              |
|  +--------------------------------------------------+        |
|  |                                                  |        |
|  |              KAMPANYALAR                         |        |
|  |                                                  |        |
|  +--------------------------------------------------+        |
|                                                              |
+--------------------------------------------------------------+
|  FOOTER: İletişim | Hakkımızda | SSS | Şartlar | Sosyal      |
+--------------------------------------------------------------+
```

#### Araç Listeleme Sayfası

```
+--------------------------------------------------------------+
|  LOGO   | ANASAYFA | ARAÇLAR | REZERVASYON | BLOG | İLETİŞİM |
+--------------------------------------------------------------+
|  [Üye Girişi]                               [0850 123 45 67] |
+--------------------------------------------------------------+
|                                                              |
|  +--------------+      +-----------------------------+       |
|  | FİLTRELER    |      | SIRALAMA: [Fiyat (A-Z) ▼]   |       |
|  | Marka [▼]    |      +-----------------------------+       |
|  | Model [▼]    |                                            |
|  | Vites [▼]    |      +-----------------------------+       |
|  | Yakıt [▼]    |      | Toyota Corolla              |       |
|  | Fiyat [----] |      | • Otomatik • Benzin • 2022  |       |
|  |              |      | [Resim]                     |       |
|  | Özellikler   |      | 850 TL / gün                |       |
|  | □ Navigasyon |      | [      İNCELE     ]         |       |
|  | □ Bluetooth  |      +-----------------------------+       |
|  | □ Cam Tavan  |                                            |
|  | □ Yol Bilgis.|      +-----------------------------+       |
|  |              |      | Honda Civic                 |       |
|  | [UYGULA]     |      | • Otomatik • Dizel • 2021   |       |
|  +--------------+      | [Resim]                     |       |
|                        | 800 TL / gün                |       |
|                        | [      İNCELE     ]         |       |
|                        +-----------------------------+       |
|                                                              |
|                        +-----------------------------+       |
|                        | Mercedes C180               |       |
|                        | • Otomatik • Benzin • 2022  |       |
|                        | [Resim]                     |       |
|                        | 1100 TL / gün               |       |
|                        | [      İNCELE     ]         |       |
|                        +-----------------------------+       |
|                                                              |
+--------------------------------------------------------------+
|  FOOTER: İletişim | Hakkımızda | SSS | Şartlar | Sosyal      |
+--------------------------------------------------------------+
```

## 9. TEKNİK GEREKSİNİMLER

### Donanım Gereksinimleri

- **Sunucu:**
  - İşlemci: Intel Xeon E5-2670 veya dengi (minimum 8 çekirdek)
  - RAM: 16 GB (minimum)
  - Depolama: 1 TB SSD (RAID 1 yapılandırması önerilir)
  - Ağ: 1 Gbps Ethernet
  - Yedekleme Ünitesi: Harici depolama veya bulut yedekleme

- **İstemci (Masaüstü Uygulaması İçin):**
  - İşlemci: Intel Core i5 (8. nesil veya üzeri) veya dengi
  - RAM: 8 GB
  - Depolama: 256 GB SSD
  - Ekran Çözünürlüğü: 1920x1080 (Full HD)
  - Ağ: 100 Mbps Ethernet veya WiFi

### Yazılım Gereksinimleri

- **Sunucu:**
  - İşletim Sistemi: Windows Server 2019 veya yeni sürüm
  - Veritabanı: MySQL 8.0 veya MSSQL Server 2019
  - Web Sunucu: IIS 10 veya Apache 2.4
  - .NET Framework 4.8 veya üzeri
  - SSL Sertifikası

- **İstemci (Masaüstü Uygulaması İçin):**
  - İşletim Sistemi: Windows 10/11
  - .NET Framework 4.8 veya üzeri
  - Crystal Reports Runtime
  - PDF Reader
  - Microsoft Office veya uyumlu ofis paketi

- **Web Sitesi:**
  - Frontend: HTML5, CSS3, JavaScript, Bootstrap 5
  - Backend: ASP.NET Core MVC veya PHP 8.0 + Laravel
  - Tarayıcı Uyumluluğu: Chrome, Firefox, Safari, Edge (son 2 sürüm)
  - Mobil Uyumluluk: Responsive tasarım

### Bağlantı Gereksinimleri

- İnternet Bağlantısı: Fiber (minimum 50 Mbps)
- Yerel Ağ: Gigabit Ethernet
- VPN: Uzaktan erişim için güvenli VPN yapılandırması
- Güvenlik: Güvenlik duvarı, IPS/IDS

### Sistem Gereksinimleri

- Günlük Veritabanı Yedekleme
- Haftalık Tam Sistem Yedekleme
- Düşük Gecikme Süresi (<100 ms)
- 7/24 Çalışma Süresi (%99.9 uptime)
- Eşzamanlı Kullanıcı Desteği: 50+ kullanıcı
- Ortalama Sayfa Yükleme Süresi: <3 saniye

## 10. PROJE ZAMAN PLANI

### Fazlar ve Tahmini Süreler

1. **Planlama ve Analiz** (4 hafta)
   - İhtiyaç analizi (1 hafta)
   - Sistem tasarımı (2 hafta)
   - Gereksinimlerin detaylandırılması (1 hafta)

2. **Veritabanı Tasarımı** (3 hafta)
   - Veritabanı şeması oluşturma (1.5 hafta)
   - İlişkisel model tasarımı (1 hafta)
   - Örnek veri oluşturma (0.5 hafta)

3. **Masaüstü Uygulaması Geliştirme** (16 hafta)
   - Temel altyapı (4 hafta)
     - Kullanıcı giriş sistemi
     - Ana menü ve navigasyon
     - Temel veritabanı bağlantıları
   - Araç ve müşteri yönetimi (4 hafta)
     - Araç modülü ve CRUD işlemleri
     - Müşteri modülü ve CRUD işlemleri
   - Kiralama ve satış modülleri (4 hafta)
     - Kiralama işlemleri
     - Sözleşme oluşturma
     - Satış işlemleri
   - Finans ve raporlama (4 hafta)
     - Finans modülü
     - Rapor oluşturma
     - Dashboard geliştirme

4. **Web Sitesi Geliştirme** (10 hafta)
   - Arayüz tasarımı (2 hafta)
     - Mockup hazırlama
     - Responsive tasarım
   - Frontend geliştirme (4 hafta)
     - HTML/CSS kodlama
     - Kullanıcı arayüzü
     - Form işlemleri
   - Backend ve API geliştirme (4 hafta)
     - Sunucu tarafı kod
     - Veritabanı bağlantıları
     - API endpoints

5. **Entegrasyon** (4 hafta)
   - Masaüstü ve web entegrasyonu (2 hafta)
   - Üçüncü taraf servis entegrasyonları (2 hafta)

6. **Test ve Hata Ayıklama** (6 hafta)
   - Fonksiyonel testler (2 hafta)
   - Kullanıcı kabul testleri (2 hafta)
   - Performans ve güvenlik testleri (2 hafta)

7. **Dokümantasyon ve Eğitim** (2 hafta)
   - Kullanıcı kılavuzları (1 hafta)
   - Teknik dokümantasyon (1 hafta)

8. **Canlı Ortama Geçiş** (3 hafta)
   - Pilot uygulama (1 hafta)
   - İnce ayarlar (1 hafta)
   - Tam geçiş (1 hafta)

**Toplam Süre:** Yaklaşık 48 hafta (12 ay)

### Gantt Şeması (Özet)

```
Ay |  1  |  2  |  3  |  4  |  5  |  6  |  7  |  8  |  9  | 10  | 11  | 12  |
---|-----|-----|-----|-----|-----|-----|-----|-----|-----|-----|-----|-----|
P&A|=====|     |     |     |     |     |     |     |     |     |     |     |
VT |     |=====|     |     |     |     |     |     |     |     |     |     |
MU |     |     |=====|=====|=====|=====|     |     |     |     |     |     |
WEB|     |     |     |     |=====|=====|=====|     |     |     |     |     |
ENT|     |     |     |     |     |     |     |=====|     |     |     |     |
TST|     |     |     |     |     |     |     |     |=====|=====|     |     |
DOK|     |     |     |     |     |     |     |     |     |     |=====|     |
CAN|     |     |     |     |     |     |     |     |     |     |     |=====|

P&A: Planlama ve Analiz  VT: Veritabanı Tasarımı
MU: Masaüstü Uygulaması  WEB: Web Sitesi Geliştirme
ENT: Entegrasyon         TST: Test ve Hata Ayıklama
DOK: Dokümantasyon       CAN: Canlı Ortama Geçiş
```

### Kilometre Taşları

- **1. Ay Sonu:** Gereksinim analizi ve sistem tasarımı tamamlanması
- **3. Ay Sonu:** Veritabanı tasarımı ve temel masaüstü altyapısı tamamlanması
- **6. Ay Sonu:** Masaüstü uygulaması MVP sürümü
- **9. Ay Sonu:** Web sitesi beta sürümü ve API entegrasyonu
- **11. Ay Sonu:** Tüm testlerin tamamlanması ve hataların giderilmesi
- **12. Ay Sonu:** Sistem canlıya alınması

## 11. TEST STRATEJİSİ

### Test Seviyeleri

1. **Birim Testleri**
   - Masaüstü uygulamasının ve web sitesinin her modülü için
   - Veritabanı işlemleri için CRUD testleri
   - Input validasyon testleri

2. **Entegrasyon Testleri**
   - Modüller arası entegrasyon
   - API testleri
   - Masaüstü ve web arasındaki senkronizasyon testleri

3. **Sistem Testleri**
   - Performans testleri
   - Yük testleri
   - Güvenlik testleri
   - Veri bütünlüğü testleri

4. **Kabul Testleri**
   - Kullanıcı kabul testleri
   - İş süreçleri doğrulama testleri

### Test Metodolojisi

- Her sprint sonunda test yapılması
- Otomatik ve manuel testlerin kombinasyonu
- Hata takip sistemi kullanılması
- Regresyon testleri ile değişikliklerden sonra mevcut işlevselliğin korunduğunun doğrulanması

### Test Araçları

- NUnit veya MSTest (birim testleri için)
- Selenium (web arayüz testleri için)
- Postman veya SoapUI (API testleri için)
- JMeter (performans testleri için)

### Test Belgeleri

- Test planı
- Test senaryoları
- Test raporları
- Hata raporları

## 12. RİSKLER VE ÇÖZÜM ÖNERİLERİ

### Olası Riskler

1. **Proje Zamanlaması Riskleri**
   - Öngörülemeyen teknik zorluklar
   - Kapsam değişiklikleri
   - Kaynak kısıtlamaları

2. **Teknik Riskler**
   - Veri bütünlüğü sorunları
   - Performans darboğazları
   - Güvenlik açıkları
   - Teknoloji uyumsuzlukları

3. **Operasyonel Riskler**
   - Kullanıcı direnci
   - İş süreci değişikliklerinin yönetimi
   - Çalışan adaptasyon sorunları

4. **Dış Kaynaklı Riskler**
   - Mevzuat değişiklikleri
   - Rekabet koşullarındaki değişimler
   - Tedarikçi bağımlılıkları

### Çözüm Önerileri

1. **Proje Yönetimi**
   - Çevik (Agile) metodoloji kullanımı
   - Düzenli ilerleme raporları ve durum toplantıları
   - Kapsamın net tanımlanması ve değişiklik yönetimi
   - Yeterli zaman tamponu bırakma

2. **Teknik Çözümler**
   - Modüler mimari tasarımı
   - Düzenli kod gözden geçirmeleri
   - Kapsamlı test senaryoları
   - Performans optimizasyonu
   - Güvenlik en iyi uygulamaları

3. **Değişim Yönetimi**
   - Kullanıcı eğitimleri
   - Detaylı dokümantasyon
   - Pilot uygulama ile geçiş
   - Kullanıcı geri bildirimleri

4. **Risk İzleme ve Kontrol**
   - Risk kaydı tutma
   - Düzenli risk değerlendirme toplantıları
   - Acil durum planları
   - Sürekli iyileştirme

## 13. GÜVENLİK ÖNLEMLERİ

### Veri Güvenliği

- Hassas verilerin şifrelenmesi (AES-256)
- Veritabanı erişim kontrolü
- Veri yedekleme ve kurtarma planları
- Kişisel verilerin KVKK uyumlu işlenmesi
- Veri anonimleştirme ve maskeleme

### Uygulama Güvenliği

- Oturum yönetimi ve zaman aşımı
- Güçlü parola politikaları
- İki faktörlü kimlik doğrulama (2FA)
- Rol tabanlı yetkilendirme
- Giriş kontrolü ve log kayıtları
- Güvenli kod geliştirme pratikleri

### Ağ Güvenliği

- SSL/TLS şifreleme (HTTPS)
- Güvenlik duvarı yapılandırması
- API güvenliği (token tabanlı)
- DoS/DDoS koruması
- İzinsiz giriş tespit ve önleme sistemleri

### Güvenlik Testleri

- Zafiyet taramaları
- Penetrasyon testleri
- Kod güvenlik incelemeleri
- Sosyal mühendislik testleri

## 14. BÜTÇE TAHMİNİ

### Geliştirme Maliyetleri

- Masaüstü uygulaması geliştirme
- Web sitesi geliştirme
- Veritabanı tasarımı ve kurulumu
- API geliştirme ve entegrasyon
- Test ve kalite güvence
- Dokümantasyon ve eğitim

### Donanım ve Yazılım Maliyetleri

- Sunucu donanımı (veya bulut hizmeti)
- Veritabanı lisansları
- Geliştirme araçları ve lisanslar
- Domain ve hosting
- SSL sertifikası
- Yedekleme çözümleri

### Operasyonel Maliyetler

- Bakım ve destek
- Güvenlik denetimleri
- Veri yedekleme çözümleri
- Eğitim maliyetleri
- Danışmanlık hizmetleri

*Not: Bu proje şu anda sadece Sistem Analizi ve Tasarımı dersi için
oluşturulmaktadır. Daha sonrasında tarafımca (Kemal Aslıyüksek)
geliştirilip somut bir projeye dönüştürülecektir. Detaylı bütçe, proje hayata geçirilirken oluşturulacaktır.*

## 15. BEKLENEN FAYDALAR

### Operasyonel Faydalar

- İş süreçlerinde %30-40 verimlilik artışı
- Manuel işlemlerin otomasyonu ile hata oranlarında azalma
- Araç doluluk oranlarının optimizasyonu
- Daha hızlı ve güvenilir müşteri hizmeti
- Personel verimliliğinde artış
- Bilgiye hızlı erişim

### Finansal Faydalar

- Kağıt ve fiziksel depolama maliyetlerinde azalma
- İş gücü verimliliğinde artış
- Daha iyi envanter yönetimi ile maliyetlerin optimizasyonu
- Online rezervasyon sistemi ile satış artışı
- Dolandırıcılık ve kayıpların azaltılması
- Kaynakların daha etkin kullanımı

### Stratejik Faydalar

- Müşteri memnuniyetinde artış
- Rekabet avantajı elde etme
- Veri analitiği ile stratejik karar alma yeteneği
- Ölçeklenebilir ve genişletilebilir sistem altyapısı
- Marka imajının güçlendirilmesi
- Dijital dönüşüm yolunda önemli bir adım

## 16. GELİŞTİRME VE İLERLEME PLANI

### Aşamalı Uygulama Planı

**Aşama 1 (Temel İşlevler)**
- Kullanıcı yönetimi
- Araç yönetimi (temel)
- Müşteri yönetimi (temel)
- Kiralama işlemleri (temel)
- Basit raporlar

**Aşama 2 (Gelişmiş İşlevler)**
- Satış işlemleri
- Finans yönetimi (temel)
- Web sitesi (temel)
- API entegrasyonu
- Gelişmiş raporlar

**Aşama 3 (İleri Seviye)**
- CRM özellikleri
- Gelişmiş finans yönetimi
- Ödeme entegrasyonları
- Mobil uyumluluk
- Analitik ve dashboard

**Aşama 4 (Tamamlama)**
- Tam entegrasyon
- Gelişmiş güvenlik
- İş zekası ve veri analitiği
- Sürekli iyileştirme
- Ek modüller ve özellikler

### İleri Seviye Geliştirme Planı

İleride eklenebilecek özellikler:
- Mobil uygulama
- Araç takip ve GPS entegrasyonu
- Müşteri sadakat programı
- Yapay zeka destekli analitik
- Blockchain tabanlı güvenlik
- Chatbot müşteri desteği
- Araç bakım ve servis modülü
- Sigorta entegrasyonu
- Çok dilli destek

---

*Bu rapor, [KEMAL ASLIYÜKSEK] tarafından Sistem Analizi ve Tasarımı dersi kapsamında hazırlanmıştır. Rapor içeriği proje geliştirme sürecinde güncellenebilir.*
