Console.WriteLine("Yol Arkadaşına Hoşgeldiniz:)");
string cevap = "";
do
{
 //kullanıcıya tatil planı yaptırıyoruz.Önce lokasyon sorulacak.
    Console.Write("Hangi lokasyonda tatil yapmak istediğinizi giriniz:");
    string lokasyon = Console.ReadLine().ToLower();

    while (lokasyon != "bodrum" && lokasyon != "marmaris" && lokasyon != "çeşme")
    {
        Console.Write("Lütfen bodrum/marmaris/çeşme lokasyonlarından birini giriniz:");
        lokasyon = Console.ReadLine().ToLower();
    }
 //kullanıcıya kaç kişi olduğunu soruyoruz.
    Console.Write("Lütfen kaç kişi olduğunuzu giriniz:");
    int kisiSayisi = Convert.ToInt32(Console.ReadLine());
 //seçilen lokasyona göre yapılacak aktiviteleri listeleyeceğiz.
    switch (lokasyon)
    {
        case "bodrum":
            Console.WriteLine("Bodrum’da yapılabilecek keyifli aktiviteler:" +
                "\n1-Bodrum Kalesi ve Sualtı Arkeoloji Müzesi’ni Gezmek" +
                
                "\n2-Tekne Turu Yapmak" +
                
                "\n3-Barlar Sokağında Gece Hayatını Deneyimlemek" +
                
                "\n4-Gümüşlük’te Gün Batımını İzlemek" +
                
                "\n5-Yelken veya Dalış Eğitimi Almak");
            break;
        case "marmaris":
            Console.WriteLine("Marmaris’te yapılabilecek 5 güzel aktivite:" +
                "\n1-Marmaris Kalesi ve Müzesi’ni Ziyaret Etmek" +

                "\n2-Tekne Turu ile Cennet Adası, Akvaryum Koyu gibi Yerleri Keşfetmek" +

                "\n3-İçmeler Plajı’nda Deniz Keyfi Yapmak" +

                "\n4-Jeep Safari ile Bozburun ve Orhaniye’yi Keşfetmek" +

                "\n5-Uzunyalı Sahilinde Bisiklet veya Yürüyüş Yapmak");
            break;
        case "çeşme":
            Console.WriteLine("İşte Çeşme'de yapılabilecek keyifli aktiviteler:" +
                "\n1-Alaçatı’da Rüzgar Sörfü Yapmak" +

                "\n2-Çeşme Kalesi ve Kervansaray’ı Ziyaret Etmek" +

                "\n3-Delikli Koy’da Doğayla Buluşmak" +

                "\n4-Çeşme Kumrusu Tatmak");
            break;

    }
 //kullanıcıya ulaşım yolunu soruyoruz.
    Console.Write("Hangi ulaşım yolunu tercih edersiniz?(1-Kara yolu 2-Hava yolu):");
    string ulasımYolu = Console.ReadLine();
    while (ulasımYolu != "1" && ulasımYolu != "2")
    {
        Console.Write("Lütfen 1 veya 2 şeklinde giriş yapınız:");
        ulasımYolu = Console.ReadLine();
    }
 //kullanıcıya tatil planı için fiyatı hesaplıyoruz.
    int fiyat = 0;
    if (lokasyon == "bodrum")
        fiyat = kisiSayisi * 2000;
    else if (lokasyon == "marmaris")
        fiyat = kisiSayisi * 3000;
    else if (lokasyon == "çeşme")
        fiyat = kisiSayisi * 5000;

  fiyat += (ulasımYolu == "1") ? kisiSayisi * 1500 : kisiSayisi * 4000;

    Console.WriteLine($"Tatiliniz ücreti {fiyat}TL'dir");
 //kullanıcıya başka bir tatil planlamak isteyip istemediğini soruyoruz.
    do { Console.Write("Başka bir tatil planlamak istiyor musunuz?(Evet/Hayır):");
        cevap = Console.ReadLine().ToLower();
        if (cevap != "evet" && cevap != "hayır")
            Console.Write("Lütfen sadece 'evet' veya 'hayır' yazınız:");
        } while (cevap != "evet" && cevap != "hayır") ;
 //kullanıcı evet derse döngüyü yeniden başlatıyoruz.
    } while (cevap == "evet");
 //kullanıcı hayır derse programı sonlandırıyoruz.
 Console.WriteLine("İyi tatiller dileriz:)");
