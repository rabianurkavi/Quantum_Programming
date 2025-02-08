namespace quantum {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;

    //rastgele bir bit üreten fonksiyon

    operation GenerateRandomBit(): Result{
        //kubit olarak ata
        use q= Qubit();

        //süperpozisyon için hadamard kapısını uygula
        H(q);

        //qubiti ölç ve sonucu kaydet
        let result = M(q);

        //qubiti sıfır durumuna döndür
        Reset(q);

        //ölç
        return result;
    }
    

    @EntryPoint()
    operation HelloQ() : Unit {
        Message("Hello quantum world!");

        let randomBit= GenerateRandomBit();
        if(randomBit==Zero){
            Message("Generated Random Bit: 0");
        }
        else{
            Message("Generated Random Bit: 1");
        }
    }
    // 
    //   Qubit'lerin Serbest Bırakılmadan Önce Sıfır Durumuna Olması Gerekliliği
    //   Q# dilinde, bir qubit'in kullanılmasından sonra |0⟩ (sıfır) durumuna geri döndürülmesi zorunludur.
    //   Bunun nedeni, kuantum bilgisayarlarda kaynak yönetiminin düzgün yapılmasıdır:
    //   Qubit'ler fiziksel olarak sınırlı bir kaynaktır.
    //   Kullanılmış bir qubit'in sıfır durumuna döndürülmesi, yeniden kullanılabilir hale gelmesi için gereklidir.
    //   Eğer qubit sıfır durumuna getirilmeden serbest bırakılırsa, ReleasedQubitsAreNotInZeroState gibi hatalar alırsın. 
    //   Qubit'ler süperpozisyon veya başka bir durumda bırakılırsa, diğer işlemler bu belirsiz durumdan etkilenebilir.
    //   Sıfır durumuna döndürerek, sistemin temiz ve yeniden kullanılabilir bir durumda kalmasını sağlarız.
    //  Eğer qubit sıfırlanmazsa, diğer operasyonlar bu qubit'in önceki durumundan etkilenebilir ve yanlış sonuçlara yol açabilir.
    //   Kuantum durumları genellikle ölçümle çöker (collapse).
    //   Ölçümden sonra qubit ya |0⟩ ya da |1⟩ durumuna gelir.
    //   Eğer qubit ölçümden sonra |1⟩ durumundaysa, onu sıfır durumuna döndürmek için bir X kapısı (NOT işlemi) uygularız:

    //     if (M(q) == One) {
    //     X(q);
    //    }
    // 


    // Qubit ölçüm sonuçları:
    // 0: Qubit |0⟩ durumunda ölçüldü.
    // 1: Qubit |1⟩ durumunda ölçüldü.
    // Qubit, Hadamard kapısı uygulandıktan sonra %50 olasılıkla |0⟩ veya |1⟩ durumunda ölçülür.
    // Sonuç 1 çıktı, bu da qubit'in süperpozisyondan çöktüğünde (collapse) |1⟩ durumunda olduğunu ifade eder. 0 da çıksa da aynı şeyi ifade edecekti. Ölçümden önce ikiside olabilir.
    //Buradaki asıl amaç, süperpozisyondaki qubit'i ölçerek onu kesin bir duruma (|0⟩ veya |1⟩) çökertmek!
}

