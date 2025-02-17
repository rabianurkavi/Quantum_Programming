//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Intrinsic.Interfaces;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"RandomNumber\",\"Name\":\"GenerateRandomBit\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\kavir\\\\quantum\\\\src\\\\Other\\\\RandomNumber\\\\Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"Result\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"RandomNumber\",\"Name\":\"GenerateRandomBit\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\kavir\\\\quantum\\\\src\\\\Other\\\\RandomNumber\\\\Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":28}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"RandomNumber\",\"Name\":\"HelloQ\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":43,\"Item2\":4},\"Comments\":{\"OpeningComments\":[\" operation GenerateRandomNumberInRange(max:Int): Int {\",\"\",\"     //bits adlı bir liste oluşturuluyor. Başlangıçta boş olan bu liste, rastgele bit değerlerini saklamak için kullanılacak.\",\"     mutable bits=[];\",\"\",\"     //Örneğin, max=10 için BitSizeI(10) = 4 olur çünkü 10'u ikili sistemde (binary) ifade etmek için 4 bit gerekir (1010).\",\"     let nBits=BitSizeI(max);\",\"\",\"     //Her iterasyonda GenerateRandomBit() fonksiyonu çağrılarak rastgele bir bit üretiliyor (0 veya 1).\",\"     //Bu bit, bits listesine ekleniyor.\",\"     for idxBit in 1..nBits {\",\"         bits += [GenerateRandomBit()];\",\"     }\",\"     let sample = ResultArrayAsInt(bits);\",\"\",\"     return sample > max ? GenerateRandomNumberInRange(max) | sample;\",\"\",\" }\"],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\kavir\\\\quantum\\\\src\\\\Other\\\\RandomNumber\\\\Program.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"RandomNumber\",\"Name\":\"HelloQ\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\kavir\\\\quantum\\\\src\\\\Other\\\\RandomNumber\\\\Program.qs\",\"Position\":{\"Item1\":44,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":17}},\"Documentation\":[]}")]
#line hidden
namespace RandomNumber
{
    [SourceLocation("C:\\Users\\kavir\\quantum\\src\\Other\\RandomNumber\\Program.qs", OperationFunctor.Body, 8, 45)]
    public partial class GenerateRandomBit : Operation<QVoid, Result>, ICallable
    {
        public GenerateRandomBit(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "GenerateRandomBit";
        String ICallable.FullName => "RandomNumber.GenerateRandomBit";
        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> Microsoft__Quantum__Intrinsic__M
        {
            get;
            set;
        }

        protected ICallable<Qubit, QVoid> Reset__
        {
            get;
            set;
        }

        public override Func<QVoid, Result> __Body__ => (__in__) =>
        {
#line hidden
            {
#line 10 "C:\\Users\\kavir\\quantum\\src\\Other\\RandomNumber\\Program.qs"
                var q = Allocate__.Apply();
#line hidden
                bool __arg1__ = true;
                try
                {
#line 13 "C:\\Users\\kavir\\quantum\\src\\Other\\RandomNumber\\Program.qs"
                    Microsoft__Quantum__Intrinsic__H.Apply(q);
#line 16 "C:\\Users\\kavir\\quantum\\src\\Other\\RandomNumber\\Program.qs"
                    var result = Microsoft__Quantum__Intrinsic__M.Apply(q);
#line 19 "C:\\Users\\kavir\\quantum\\src\\Other\\RandomNumber\\Program.qs"
                    Reset__.Apply(q);
#line 22 "C:\\Users\\kavir\\quantum\\src\\Other\\RandomNumber\\Program.qs"
                    return result;
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(q);
                    }
                }
            }
        }

        ;
        public override void __Init__()
        {
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Intrinsic__M = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Intrinsic.M));
            this.Reset__ = this.__Factory__.Get<ICallable<Qubit, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Reset));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(Result data) => new QTuple<Result>(data);
        public static System.Threading.Tasks.Task<Result> Run(IOperationFactory __m__)
        {
            return __m__.Run<GenerateRandomBit, QVoid, Result>(QVoid.Instance);
        }
    }

    [SourceLocation("C:\\Users\\kavir\\quantum\\src\\Other\\RandomNumber\\Program.qs", OperationFunctor.Body, 45, -1)]
    public partial class HelloQ : Operation<QVoid, QVoid>, ICallable
    {
        public HelloQ(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "HelloQ";
        String ICallable.FullName => "RandomNumber.HelloQ";
        public static EntryPointInfo<QVoid, QVoid> Info => new EntryPointInfo<QVoid, QVoid>(typeof(HelloQ));
        protected ICallable<String, QVoid> Message__
        {
            get;
            set;
        }

        protected ICallable<QVoid, Result> GenerateRandomBit__
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> __Body__ => (__in__) =>
        {
#line 46 "C:\\Users\\kavir\\quantum\\src\\Other\\RandomNumber\\Program.qs"
            Message__.Apply("Hello quantum world!");
#line 48 "C:\\Users\\kavir\\quantum\\src\\Other\\RandomNumber\\Program.qs"
            var randomBit = GenerateRandomBit__.Apply(QVoid.Instance);
#line 49 "C:\\Users\\kavir\\quantum\\src\\Other\\RandomNumber\\Program.qs"
            if ((randomBit == Result.Zero))
            {
#line 50 "C:\\Users\\kavir\\quantum\\src\\Other\\RandomNumber\\Program.qs"
                Message__.Apply("Generated Random Bit: 0");
            }
            else
            {
#line 53 "C:\\Users\\kavir\\quantum\\src\\Other\\RandomNumber\\Program.qs"
                Message__.Apply("Generated Random Bit: 1");
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Message__ = this.__Factory__.Get<ICallable<String, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Message));
            this.GenerateRandomBit__ = this.__Factory__.Get<ICallable<QVoid, Result>>(typeof(GenerateRandomBit));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<HelloQ, QVoid, QVoid>(QVoid.Instance);
        }
    }
}