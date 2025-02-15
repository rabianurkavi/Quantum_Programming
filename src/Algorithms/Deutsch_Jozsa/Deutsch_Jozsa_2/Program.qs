namespace Deutsch_Jozsa_2 {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    
    operation ConstantOracle(input: Qubit[], target: Qubit, isOne: Bool) : Unit is Adj + Ctl {
        if (isOne) {
            // Eğer sabit 1 ise hedef qubiti çevir
            X(target);
        }
        // Sabit 0 için hiçbir şey yapmaya gerek yok
    }
    /// Dengeli oracle fonksiyonu - girdilerin yarısı için 0, diğer yarısı için 1 döndürür
    operation BalancedOracle(input: Qubit[], target: Qubit) : Unit is Adj + Ctl {
        // İlk qubit 1 ise hedef qubiti çevir
        CNOT(input[0], target);
    }
    /// Deutsch-Jozsa algoritmasının ana implementasyonu
    operation DeutschJozsa(nQubits: Int, oracle: ((Qubit[], Qubit) => Unit is Adj + Ctl)) : Bool {
        // Sonuç true ise fonksiyon sabittir, false ise dengelidir
        mutable isConstant = true;
        
        // Girdi qubitleri ve hedef qubit için kaynak ayır
        use (input, target) = (Qubit[nQubits], Qubit()) {
            // Hedef qubiti |1⟩ durumuna getir
            X(target);
            
            // Tüm qubitlere Hadamard uygula
            ApplyToEach(H, input);
            H(target);
            
            // Oracle fonksiyonunu uygula
            oracle(input, target);
            
            // Girdi qubitlerine tekrar Hadamard uygula
            ApplyToEach(H, input);
            
            // Ölçüm yap - herhangi bir qubit |1⟩ durumunda ise fonksiyon dengelidir
            for q in input {
                if (M(q) == One) {
                    set isConstant = false;
                }
            }
            
            // Qubitleri sıfırla
            ResetAll(input);
            Reset(target);
        }
        
        return isConstant;
    }


    @EntryPoint()
    operation HelloQ() : Unit {
      let nQubits = 3; // Test için 3 qubitlik sistem
        
        // Sabit oracle (hep 0 döndüren) ile test
        Message("Sabit Oracle (0) Testi:");
        let constResult0 = DeutschJozsa(nQubits, ConstantOracle(_, _, false));
        Message($"Sonuç: {constResult0 ? "Sabit" | "Dengeli"}");
        
        // Sabit oracle (hep 1 döndüren) ile test
        Message("\nSabit Oracle (1) Testi:");
        let constResult1 = DeutschJozsa(nQubits, ConstantOracle(_, _, true));
        Message($"Sonuç: {constResult1 ? "Sabit" | "Dengeli"}");
        
        // Dengeli oracle ile test
        Message("\nDengeli Oracle Testi:");
        let balancedResult = DeutschJozsa(nQubits, BalancedOracle);
        Message($"Sonuç: {balancedResult ? "Sabit" | "Dengeli"}");
    }
}

