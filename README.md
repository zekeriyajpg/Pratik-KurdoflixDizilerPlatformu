# Pratik Kürdoflix Diziler Platformu

Bu proje, kullanıcıların dizileri girmesine ve bunları bir listeye eklemesine olanak tanır. Kullanıcılar, eklenen diziler arasından yalnızca komedi türündeki dizileri seçip bu dizileri sıralayarak ekrana yazdırabilirler.

## Proje İçeriği

Bu proje, kullanıcıdan alınan dizileri bir listeye ekler ve ardından bu diziler arasından yalnızca komedi türündeki dizileri seçip sıralı bir şekilde ekrana yazdırır.

### Kod Açıklaması

1. **Dizi Sınıfı**: 
    - `DiziAdi`: Dizinin adı.
    - `DiziTuru`: Dizinin türü (komedi, drama vb.).
    - `Yönetmen`: Dizinin yönetmeni.
    - `BölümSayisi`: Dizinin bölüm sayısı.
    - `YayınKanalı`: Dizinin yayınlandığı kanal.

2. **KomediDizisi Sınıfı**: 
    dizi sınıfından miras alınarak yapıldı

### Kullanım Talimatları

1. **Dizi Bilgilerini Girmek**:
    - Program, kullanıcıdan dizinin adını, türünü, yönetmenini, bölüm sayısını ve yayın kanalını girmesini ister.
    - Kullanıcı, yeni diziler eklemeye devam etmek isteyip istemediğini belirten bir yanıt verir (E/H).

2. **Komedi Dizileri Listesi Oluşturmak**:
    - Kullanıcıdan alınan diziler arasında "komedi" türündeki diziler seçilir.
    - Bu diziler, dizi adı ve yönetmene göre sıralanır.

3. **Sonuçların Ekrana Yazdırılması**:
    - Komedi türündeki diziler sıralı bir şekilde ekrana yazdırılır.
