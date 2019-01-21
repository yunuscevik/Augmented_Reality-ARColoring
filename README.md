# Augmented_Reality-ARColoring

### Projenin Tanımı

Anasınıfı veya ilkokul çağındaki çocukların boyama yaparken iki boyutlu çizimleri, üç boyutlu modellere dönüştürerek onların hayal güçlerini geliştirmeye yardımcı olan “AR Coloring” projesi; çocuklara boyamayı daha eğlenceli ve gizemli kılmayı amaçlamaktadır.

### Yöntem

Çocukların boyama esnasında ilgisini çekebilecek projenin amacına uygun üç boyutlu bir obje belirlenir. Bu nesnenin AutoDesk 3DS Max uygulamasıyla belirlenen modelin boyama kağıdı üzerinde nasıl görüntüleneceği aşağıdaki şekilde belirlenir:

  * 3B Nesne doğru açıyla konumlandırılır.
  * Bir ışık kaynağı yardımıyla gölgelendirme yapılır.
  * Üç boyutlu modelin iki boyutlu gösterimine derinlik kazandırılmış olur.
  * 3DS Max uygulamasında sanal bir kamera yardımıyla bu modelin ekran görüntüsü alınır.
  * Görüntüler siyah-beyaz ya da gri tonlamalı olarak filtre edilir,
  * Ana hatlar belirlenerek çocuklar boyama yapabileceği taslak dönüştürülür. Bu taslak marker olarak belirlenir.
Modelin kopyası oluşturulur, bu kopyaya marker olarak belirlenen taslak, materyal olarak belirlenir. Bu materyaller modelin kopyası üzerinde mapping (haritalandırma) yapılarak modelin ilgili yerlerine giydirme yapılır. Bu giydirme işlemi objenin ortadan ikiye ayrılmış bir yarısında uygulanır. Daha sonra bu işlemin simetriği alınarak model giydirmesi düzgün bir biçimde tamamlanmış olur.

### Unity & Vuforia
Oluşturulan marker Unity içerisinde image target belirlenir. Image target üzerinde bulunan taslağı algılayabilmesi için Unity Vuforia için geliştirilmiş Region Capture (bölge yakalama) eklentisi yardımıyla belirlenen iki boyutlu image target alanını taranıp giydirilmiş modelin üzerinden materyali çıkartılarak Unity platformuna eklenir. AR Kamera ve Region Capture kamerası ile belirlenen image target üzerindeki marker deseni bu model üzerinde gösterilir.
Image target üzerinde belirlediğimiz renklendirme (boyama) ya da benzeri herhangi bir işlem ile model üzerinde görüntülenmesi sağlanır.

### Sonuç
Çocuklar iki boyutlu bir resimde boyama işlemi yaparken boyadıkları objenin üç boyutlu halini hayal edebilirler. Bu proje; çocukların hayal ettikleri nesneyi görünür ve sanal bir karakter haline getirerek çocukların ilgisini çekmesini sağlar. Karaktere uyarlanan animasyonlar sayesinde de boyamayı daha eğlenceli bir hale getirir.

### MARKER (ImageTarget): 
![alt text](https://github.com/yunuscevik/Augmented_Reality-ARColoring/blob/master/MARKER-ScreenShot/MARKER.jpg "Logo Title Text 1")

### Simulated-Image1: 
![alt text](https://github.com/yunuscevik/Augmented_Reality-ARColoring/blob/master/MARKER-ScreenShot/ugandan-ss1.png "Logo Title Text 1")

### Simulated-Image2:
![alt text](https://github.com/yunuscevik/Augmented_Reality-ARColoring/blob/master/MARKER-ScreenShot/ugandan-ss2.png "Logo Title Text 1")

### Simulated-Image3:
![alt text](https://github.com/yunuscevik/Augmented_Reality-ARColoring/blob/master/MARKER-ScreenShot/ugandan-ss3.png "Logo Title Text 1")
