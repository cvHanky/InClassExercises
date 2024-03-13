
using Pr49_Scheduling;
// HUSK AT ÆNDRE DENNE USING STATEMENT SÅ DEN ER TILSVARENDE TIL DIT PROJEKT

namespace Pr49_unit_test
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void IsConstructorMade_Test()
        {
            // #### ARRANGE, ACT AND ASSERT
            PCB p = new PCB("TestProcess", 1, ProcessStateType.Ready);
        }

        [TestMethod]
        public void IsProcessNameCorrect_Test()
        {
            // #### ARRANGE 
            PCB p1 = new PCB("TestProcess", 1, ProcessStateType.Ready);
            PCB p2 = new PCB("Execution Process", 3, ProcessStateType.Running);
            PCB p3 = new PCB("Pølseprocessen", 0, ProcessStateType.New);

            // #### ASSERT
            Assert.AreEqual("TestProcess", p1.ProcessName);
            Assert.AreEqual(3, p2.ProcessPriority);
            Assert.AreEqual(ProcessStateType.New, p3.ProcessState);
        }

        [TestMethod]
        public void IsToStringMethodCorrect_Test()
        {
            // #### ARRANGE
            PCB p = new PCB("IkkeEnTestProces", 20, ProcessStateType.Waiting);

            // #### ASSERT
            Assert.AreEqual("IkkeEnTestProces(20)", p.ToString());
        }
    }
}