using System.Collections;

namespace Promedio 
{

    public class Estudiante
    {
        public string nombre;
        public char genero;
        public int edad;
        public Stack talleres;
        public Stack quizes;
        public double parcial;

        public Estudiante() 
        {
            this.nombre = "Desconocido";
            this.genero = 'I';
            this.edad = 0;
            this.parcial = 0.0;
            this.quizes = new Stack();
            this.talleres = new Stack();
        }

        public Estudiante( string pNombre, char pGenero, int pEdad)
        {
            this.nombre = pNombre;
            this.genero = pGenero;
            this.edad = pEdad;
            this.parcial = 0.0;
            this.quizes = new Stack();
            this.talleres = new Stack();
        }

        public void AddQuiz(double pQuiz) 
        {
            this.quizes.Push( pQuiz);
        }

        public void AddTaller(double pTaller)
        {
            this.talleres.Push(pTaller);
        }

        public double GetPromedioQuiz()
        {
            if (this.quizes.Count > 0)
            {
                double rPromedio = 0.0;
                Stack _tempStack =  (Stack) this.quizes.Clone();
                
                for (int i=0; i<this.quizes.Count; i++)
                {
                    rPromedio += (double) _tempStack.Pop();
                }
                rPromedio /= this.quizes.Count;

                return rPromedio;
            }
            else
            {
                return 0;
            }

        }

        public double GetPromedioTaller()
        {
            if (this.talleres.Count > 0)
            {
                double rPromedio = 0;
                Stack _tempStack = (Stack)this.talleres.Clone();
                for (int i = 0; i < this.talleres.Count; i++)
                {
                    rPromedio += (double)_tempStack.Pop();
                }
                rPromedio /= this.talleres.Count;

                return rPromedio;
            }
            else
            {
                return 0;
            }

        }

        public double GetDefinitiva()
        {   
            return (
                (this.GetPromedioQuiz()*0.05)+
                (this.GetPromedioTaller()*0.05)+
                (this.parcial*0.2)
                )/0.3;
        }

        public void Presentar()
        {
            
        }

        public string GetEstado()
        {
            if(this.GetDefinitiva() >= 4.5)
            {
                return "Excelente";
            }
            else
            {
                if(this.GetDefinitiva() >= 3)
                {
                    return "Bueno";
                }
                else
                {
                    return "Malo estudie vago";
                }
            }
        }
    }
}