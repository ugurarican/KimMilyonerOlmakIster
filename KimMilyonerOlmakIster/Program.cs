//arşılama ekranıyla kullanıcıyı karşılıyoruz.
Console.WriteLine("Kim Milyoner Olmak İster Yarışmasına HOŞGELDİNİZ.");
Console.WriteLine("--------------------------------------------------");
Console.WriteLine("Yarışma 3 Sorudan oluşmaktadır ve cevaplar iki seçeneklidir.");
Console.WriteLine("3 Sorudan en az 2 sine doğru cevap verirseniz 1 Milyon TL'li büyük ödülü kazanacaksınız.");
Console.WriteLine("Eğer 3 soruyu da doğru cevaplarsanız 2 Milyon TL kazanacaksınız.");
Console.WriteLine("İlk soruyu görmek için Enter'a basınız.");
Console.ReadLine();

// İlk sorumuzu soruyoruz ve altında cevapları yazıyoruz.
Console.WriteLine("Soru 1: Bilgisayarlarda geçici bilgilerin tutulduğu yere ne ad veriilir?");
Console.WriteLine("a) Ram b) Hard Disk");

// Ekrana girdiği seçeneği answer1 değişkeninde tutuyoruz ve if bloğu ile doğru olup olmadığını karşılaştırıyoruz.
string answer1 = Console.ReadLine().ToLower();

// Bir tane de doğru cevapları saydığımız bir sayaç ekliyoruz.
int counter = 0;
//Cevap a seçeniği yani doğruysa if bloğuna giriyor ve burada sayacımız 1 artıyor ve doğru cevap verdiği bilgisi yarışmacıya bildiriliyor.
if (answer1 == "a")
{
    counter++;
    Console.WriteLine("Tebrikler ilk soruyu doğru bildiniz.");
}
// Cevap doğru değilse sayacımız 0 olarak kalıyor ve yarışmacıya yanlış cevap verdiği
else if (answer1 == "b")
{
    Console.WriteLine("Malesef ilk soruyu yanlış cevapladınız.");
}
else
{
    Console.WriteLine("Geçersiz giriş.");
}
// İkinci sorumuzu soruyoruz ve altında cevapları yazıyoruz.
Console.WriteLine("Soru 2: Altın oran kaçtır?");
Console.WriteLine("a) 3,14 b) 1,618");
// Ekrana girdiği seçeneği answer2 değişkeninde tutuyoruz ve if bloğu ile doğru olup olmadığını karşılaştırıyoruz.
string answer2 = Console.ReadLine().ToLower();

// Cevap b seçeniği yani doğruysa if bloğuna giriyor ve burada sayacımız 1 artıyor ve doğru cevap verdiği bilgisi yarışmacıya bildiriliyor.
if (answer2 == "b")
{
    counter++;
    Console.WriteLine("Tebrikler ikinci soruyu doğru bildiniz.");
}
// Cevap doğru değilse sayacımız 0 olarak kalıyor ve yarışmacıya yanlış cevap verdiği
else if (answer2 == "a")
{
    Console.WriteLine("Malesef ikinci soruyu yanlış cevapladınız.");
}
else
{
    Console.WriteLine("Geçersiz giriş.");
}
// Burada 2 soruya da yanlış cevap verip vermediğini kontrol ediyoruz.
if (counter >=1)
{
    // Üçüncü sorumuzu soruyoruz ve altında cevapları yazıyoruz.
    Console.WriteLine("Soru 3: Kurtlar Vadisi dizisinde başrolde oynayan Polat Alemdar isimli oyuncunun yüz nakli olmadan önceki adı nedir?");
Console.WriteLine("a) Ali Candan b) Necati Şaşmaz");
// Ekrana girdiği seçeneği answer2 değişkeninde tutuyoruz ve if bloğu ile doğru olup olmadığını karşılaştırıyoruz.
string answer3 = Console.ReadLine().ToLower();

    // Cevap a seçeniği yani doğruysa if bloğuna giriyor ve burada sayacımız 1 artıyor ve doğru cevap verdiği bilgisi yarışmacıya bildiriliyor.
    if (answer3 == "a")
    {
        counter++;
        Console.WriteLine("Tebrikler üçüncü soruyu doğru bildiniz.");
    }
    // Cevap doğru değilse sayacımız 0 olarak kalıyor ve yarışmacıya yanlış cevap verdiği
    else if (answer3 == "b")
    {
        Console.WriteLine("Malesef üçüncü soruyu yanlış cevapladınız.");
    }
    else
    {
        Console.WriteLine("Geçersiz giriş.");
    }
}
else
{
    Console.WriteLine("Malesef iki soruya yanlış cevap verdiğiniz için elendiniz.");
}
// Sounuç ve değerlendirme
if (counter==3)
{
    Console.WriteLine("2 Milyon TL'lik büyük ödülü kazandınız.");
}
else if(counter == 2)
{
    Console.WriteLine("1 Milyon TL'lik ödülü kazandınız.");
}
else
{
    Console.WriteLine("Maalesef ödül kazanamadınız.");
}    
    Console.WriteLine("Oyunumuzu oynadığınız için teşekkürler.");

