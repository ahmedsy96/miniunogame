# miniunogame
Proje Detayları:
Sıra tabanlı bir kart oyunu yapılmak istenmektedir. Toplam 18 karttan oluşmakta (Tablo 1) ve oyun
başında tüm kartların 3 farklı oyuncuya eşit olarak (6 adet) dağıtılması ile oyun başlamaktadır (Tablo
2). Her bir oyuncunun elindeki kartları özel kurallara bağlı kalarak sıra ile atması gerekmektedir. Elinde
kart kalmayan oyuncu oyunu kazanır (Tablo 3).
Bu oyunda üç farklı renkte [Sarı (S), Kırmızı (K) ve Mavi (M)] 1’den 5’e kadar (1 ve 5 dahil) üzerinde
rakamların yazıldığı kartlar bulunmaktadır. 3 adet de oyun rengini değiştirmek için kullanılabilen özel
kart (Renk Değiştir kartı) bulunmaktadır. Bu özel kart aracılığıyla oyuncular oyuna istedikleri renk ile
(Sarı, Kırmızı veya Mavi) devam edilmesini sağlayabilir.
Özel Kurallar
 Oyuna başlayacak ilk oyuncu yere istediği kartı atabilir.
 Yerdeki kartın üzerindeki rakam ile aynı rakama sahip herhangi bir kart atılabilir (ör: yerde M4
varsa K4 veya S4 atılabilir).
 Yerdeki kartla aynı renkte herhangi bir kart atılabilir (ör: yerde M1 varsa M5 veya M3 atılabilir).
 Özel kart ile oyuna başlanamaz.
Gerçekleştirilmesi istenen aşamalar
 3 farklı oyuncuya rastgele 6 adet kartın dağıtılması sağlanır. (İpucu: Her bir kart RENK# olarak
(Örnek: “S1 veya SARI2” gibi) String ifadelerle temsil edilebilir ve bir String dizisi ile dağıtılan
kartlar ifade edilebilir (ör: oyuncuKart[] = {“S2”,”RD”,”M1”,”M2”,”K3”,”S5”}).)
 Yere atılan kartın geçerliliği kontrol edilmelidir. Eğer atılan kart geçerli değil ise tekrar seçim
yaptırılması gerekmektedir.
o Yere atılan kartın renginin bir önceki kart rengi ile aynı olması durumunda,
o Yere atılan kartın üzerindeki rakamın bir önceki kartın üzerindeki rakam ile aynı olması
durumunda,
o Yere “Renk Değiştir” kartı atılması durumunda,
o Pas seçeneğinin tercih edilmesi durumunda (Eğer pas seçildiyse yerdeki kartın değeri
değişmemektedir.)
yere atılan kart geçerlidir.
 “Renk Değiştir” kartının davranışı kontrol edilmelidir.
o “Renk Değiştir” kartı seçildiğinde oyuncu üç farklı renkten birini (M, K, S) seçebilir
olmalıdır.
o Bu renklerden farklı bir giriş olması durumunda seçimin geçersiz olduğu ekrana
yazdırılıp tekrar seçim yapılması sağlanmalıdır.
o Seçilen renk ve yerdeki kartın üzerindeki rakamın birleştirilmesi ile yerdeki kartın
tekrar belirlenmesi gerekmektedir. (ör: Eğer yerdeki kart M1 ise ve yeni renk S olmuş
ise yerdeki kartın yeni değeri S1 olur.)
 Bilgisayar 2. ve 3. oyuncuların davranışlarını kontrol etmelidir.
o Bilgisayar yerdeki karta uygun olarak elindeki kartlardan yeni bir tane seçip atmalıdır.
o Öncelik genel kartlar olmalıdır. Eğer elindeki genel kartlar kurallara uymuyor ise “Renk
Değiştir” kartını kullanabilir.
o “Renk Değiştir” kartını kullanmış ise elindeki kartlardan herhangi birinin rengine sahip
bir renk ile yeni rengi belirlemelidir. Elinde başka kart kalmamış ise rastgele bir renk (S,
K, M) belirleyebilir.
 Atılan kartların tekrar kullanıma kapatılması gerekmektedir. (İpucu: Eğer dizi kullanarak kartları
tasarlamış iseniz, kart kullanıldığında kartın değerini boş veya kendinize özel bir karakter
atayarak kontrol edebilirsiniz.)
 Oyunun sonlandırılma kontrollerinin gerçekleştirilmesi gerekmektedir.
o Eğer herhangi bir oyuncunun elinde kart kalmaz ise oyunu o oyuncu kazanır.
o Eğer üç tur boyunca yerdeki kart değişmez ise oyun berabere sonuçlanır.
