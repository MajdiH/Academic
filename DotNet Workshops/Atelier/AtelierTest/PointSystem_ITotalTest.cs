using Aterlier;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AtelierTest
{
    
    
    /// <summary>
    ///Classe de test pour PointSystem_ITotalTest, destinée à contenir tous
    ///les tests unitaires PointSystem_ITotalTest
    ///</summary>
    [TestClass()]
    public class PointSystem_ITotalTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Obtient ou définit le contexte de test qui fournit
        ///des informations sur la série de tests active ainsi que ses fonctionnalités.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Attributs de tests supplémentaires
        // 
        //Vous pouvez utiliser les attributs supplémentaires suivants lorsque vous écrivez vos tests :
        //
        //Utilisez ClassInitialize pour exécuter du code avant d'exécuter le premier test dans la classe
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Utilisez ClassCleanup pour exécuter du code après que tous les tests ont été exécutés dans une classe
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Utilisez TestInitialize pour exécuter du code avant d'exécuter chaque test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Utilisez TestCleanup pour exécuter du code après que chaque test a été exécuté
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        internal virtual PointSystem.ITotal Create_PointSystem_ITotal()
        {
            // TODO: instanciez une classe concrète appropriée.
            PointSystem.ITotal target = null;
            return target;
        }

        /// <summary>
        ///Test pour Increment
        ///</summary>
        [TestMethod()]
        public void IncrementTest()
        {
            PointSystem.ITotal target = Create_PointSystem_ITotal(); // TODO: initialisez à une valeur appropriée
            PointSystem.ITotal with = null; // TODO: initialisez à une valeur appropriée
            target.Increment(with);
            Assert.Inconclusive("Une méthode qui ne retourne pas une valeur ne peut pas être vérifiée.");
        }

        /// <summary>
        ///Test pour ToString
        ///</summary>
        [TestMethod()]
        public void ToStringTest()
        {
            PointSystem.ITotal target = Create_PointSystem_ITotal(); // TODO: initialisez à une valeur appropriée
            string expected = string.Empty; // TODO: initialisez à une valeur appropriée
            string actual;
            actual = target.ToString();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Vérifiez l\'exactitude de cette méthode de test.");
        }
    }
}
