using NUnit.Framework;

namespace banque_simple
{

 
    [TestFixture]
    public class CompteTest 
    {
           private Compte compte;

        // avant chaque test création d'un compte:
        [SetUp]
        public void setUp(){
            compte = new Compte(123,500,"C01");
        }

        [Test]
        public void testGetNumero(){
            long num = compte.Numero;
            Assert.AreEqual(123, num);
            //Assert.IsTrue(12315 == num); ideal booleen sinon ici on se sera pas pourquoi c false
        }
         [Test]
        public void testSetNumero(){
            compte.Numero = 258;
            int num = compte.Numero;
            Assert.AreEqual(258, num);

        }

        [Test]
        public void testSetSolde(){
            compte.Solde = 1500;
            double sold = compte.Solde;
            Assert.AreEqual(1500, sold);

        }
        [Test]
        public void testGetSolde(){
            double sold = compte.Solde;
            Assert.AreEqual(500, sold);
        }

                [Test]
        public void testSetRef(){
            compte.ReferenceClient = "PT052";
             Assert.AreEqual("PT052", compte.ReferenceClient);

        }
        [Test]
        public void testGetRef(){
            Assert.AreEqual("C01", compte.ReferenceClient);
        }

        // test constructeur:
        [Test]
        public void testCompte(){
            Compte cpt = new Compte();
            Assert.NotNull(cpt);
        }

         [Test]
        public void testCompteParam(){
            Compte cpt = new Compte(123456,258,"CPT01");
            Assert.AreEqual(123456, cpt.Numero);
            Assert.AreEqual(258, cpt.Solde);
            Assert.AreEqual("CPT01", cpt.ReferenceClient);
        }

    }

}
