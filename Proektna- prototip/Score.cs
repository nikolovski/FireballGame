using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO ;
using System.Collections ;
using System.Runtime.Serialization ;
using System.Runtime.Serialization.Formatters.Binary ;

namespace Proektna__prototip
{
    [ Serializable ]
    class Rezultat:ISerializable
    {
        public string Igrac1 { get; set; }
        public string Igrac2 { get; set; }
        public int rez1 { get; set; }
        public int rez2 { get; set; }
        public Rezultat( string i1,string i2 , int r1 , int r2 ){
             Igrac1 = i1 ;
            Igrac2 = i2 ;
             rez1 = r1 ;
             rez2 = r2;
        }
        private Rezultat ( SerializationInfo info , StreamingContext context )
        {

            rez1 = info.GetInt32("Rez1");
            rez2 = info.GetInt32("Rez2");
            

            try
            {
                Igrac1 = info.GetString("Igrac1");
               
                Igrac2 = info.GetString("Igrac2");
            }
            catch ( SerializationException )
            {
                Igrac1 = null;
                Igrac2 = null;

            }
        }
            public void GetObjectData ( SerializationInfo inf , StreamingContext con )
                {
                  
                    
                    inf.AddValue ("Rez1", rez1 );
                     inf.AddValue ("Rez2", rez2 );

                    if (( con.State & StreamingContextStates.File ) == 0)
                    {
                        inf.AddValue ("Igrac1", Igrac1 );
                        inf.AddValue ("Igrac2", Igrac2 );
                }
        }
            public override string ToString()
            {
                StringBuilder str = new StringBuilder() ;
                
                str.AppendFormat ("      {0} :", rez1 );
                str.AppendFormat (" {0}", rez2 );
                
                return str.ToString () ;
            }
}


    }

