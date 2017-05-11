using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_recursividad
{
    class Persona
    {
        public PersonaIndividual Raiz;
        public class PersonaIndividual
        {
            public PersonaIndividual Padre;
            public PersonaIndividual Hijo;
            public string Nombre;
            public int CUI;
        }

        public void MuestraArbol() {
            muestrapersona(Raiz);
        }
        void muestrapersona(PersonaIndividual Nodo)
        {
            if (Nodo.Padre != null && Nodo.Hijo != null)
            {
                Console.WriteLine(Nodo.Padre.Nombre + " (P->) " + Nodo.Nombre + " (H->) " + Nodo.Hijo.Nombre);
                muestrapersona(Nodo.Hijo);
            }
            else if (Nodo.Padre == null && Nodo.Hijo != null)
            {
                Console.WriteLine(Nodo.Nombre + " (H->) " + Nodo.Hijo.Nombre);
                muestrapersona(Nodo.Hijo);
            }
            else if (Nodo.Padre != null && Nodo.Hijo == null)
            {
                Console.WriteLine(Nodo.Padre.Nombre + " (P->) " + Nodo.Nombre);
            }
            else if (Nodo.Padre == null && Nodo.Hijo == null)
            {
                Console.WriteLine("FA-> " +Nodo.Nombre +" <-FA");

            }
        }
        public void NacePersona(string nombre, int cui, int cuipadre)
        {
            PersonaIndividual padreobj = new PersonaIndividual();
            if (cuipadre == 0)
            {
                NacePersona(nombre, cui, Raiz);
            }
            else {
                padreobj = LocalizarPadre(cuipadre, Raiz);
                NacePersona(nombre, cui, padreobj);
            }
        }

        void NacePersona(string nombre, int cui, PersonaIndividual Nodo)
        {
            if (Raiz == null)
            {
                Raiz = new PersonaIndividual();
                Raiz.CUI = cui;
                Raiz.Nombre = nombre;
            }
            else {
                if (Nodo.Hijo != null)
                {
                    NacePersona(nombre, cui, Nodo.Hijo);
                }
                else {
                    Nodo.Hijo = new PersonaIndividual();
                    Nodo.Hijo.Padre = Nodo;
                    Nodo.Hijo.CUI = cui;
                    Nodo.Hijo.Nombre = nombre;
                }
            }
        }
        public PersonaIndividual LocalizarPadre(int cui, PersonaIndividual Nodo)
        {
            if (Nodo.Hijo == null)
            {
                if (Nodo.CUI == cui)
                {
                    return Nodo;
                }
                else {
                    return null;
                }
            }
            else {
                if (Nodo.CUI == cui)
                {
                    return Nodo;
                }
                else {
                    return LocalizarPadre(cui, Nodo.Hijo);
                }
                
            }
        }
        


    }
}
