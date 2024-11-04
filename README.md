# Pratik - IMDB Listesi

 Aşağıda belirtilen adımları gerçekleştirerek bir Imdb - Film Listesi oluşturuyoruz.

* Sinema Filmlerini listeleyeceğimiz bir liste oluşturalım.

* Film için propertyler -> Imdb Puanı (Double) - İsmi 

* Kullanıcıdan sınırsız sayıda film adı ve imdb puanı isteyip bu bilgilerle nesneler oluşturulup liste doldurulacak.

* Kullanıcıya her film eklemesinden sonra yeni bir film eklemek isteyip istemediği sorulsun. Kullanıcı evet cevabını verirse döngüde başa dönülerek yeni bir film oluşturulup ilgili listeye aktarılsın. Hayır cevabı verilirse program aşağıdaki çıktıları ayrı ayrı sunarak sonlandırılsın.

  #  Uygulamanın sonunda

 * Bütün filmler listelensin.

 * Imdb puanı 4 ile 9 arasında olan bütün filmler listelensin.

 * İsmi 'A' ile başlayan filmler ve imdb puanları listelensin.

   # Kod Açıklaması

1)  Film Sınıfı: Film nesnesinin özelliklerini (İsim ve IMDB Puanı) tutan bir sınıf oluşturulur.
2) Film Listesi: List<Film> tipinde bir liste oluşturularak filmler bu listede saklanır.
3) Kullanıcıdan Veri Alma:
* Sonsuz döngü ile kullanıcıdan sürekli film bilgileri alınır.
* Kullanıcı 'e' harfi girmedikçe döngü devam eder.
* Girilen bilgiler Film nesnesine atanır ve listeye eklenir.
4) Listeleme İşlemleri:
* Tüm filmler listelenir.
* IMDB puanı 4 ile 9 arasında olan filmler listelenir.
* İsmi 'A' ile başlayan filmler listelenir.
