using GestionBanqueApp.Model.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace GestionBankApp.Model.Entities
{
    class CompteFormat
    {
        public static List<CompteCourant> aComptes = new List<CompteCourant>();
        public static List<Client> aClients = new List<Client>();
        public static List<CompteEpargne> aCompteEp = new List<CompteEpargne>();

        //Methode de chargement des données au demarrage de l'application 

        public static List<Client> chargerClient()
        {
            if (File.Exists(@"GesB_client.xml")) //s'il existe un fichier de gestion de clients
            {
                using (StreamReader reader = new StreamReader(@"GesB_client.xml")) //et on initie le flux de lecture pour le fichier
                {
                    if (!reader.EndOfStream)  //si on n'est pas en fin de fichier 
                    {
                        XmlSerializer deserializer = new XmlSerializer(typeof(List<Client>)); //on initie un objet de désérialisation
                        CompteFormat.aClients = (List<Client>)deserializer.Deserialize(reader); //on desérérialise les objets du fichier xml et on les cast en liste client
                        reader.Close(); //on ferme le flux de lecture de données
                        reader.Dispose(); // et on le detruit 

                    }
                    else
                    {
                        reader.Close();
                        reader.Dispose();
                    }
                }
            }

            return CompteFormat.aClients;

        }

        public static List<CompteCourant> chargerCourant()
        {
            if (File.Exists(@"GesB_acomptes.xml"))
            {
                using (StreamReader reader = new StreamReader(@"GesB_acomptes.xml"))
                {
                    if (!reader.EndOfStream)
                    {
                        XmlSerializer deserializer = new XmlSerializer(typeof(List<CompteCourant>));

                        CompteFormat.aComptes = (List<CompteCourant>)deserializer.Deserialize(reader);
                        reader.Close();
                        reader.Dispose();
                    }
                    else
                    {
                        reader.Close();
                        reader.Dispose();
                    }

                }
            }

            return CompteFormat.aComptes;

        }
        public static void chargerDonnees()
        {
            Console.WriteLine("entrer la");
            try
            {
                if (File.Exists(@"GesB_client.xml")) //s'il existe un fichier de gestion de clients
                {
                    using (StreamReader reader = new StreamReader(@"GesB_client.xml")) //et on initie le flux de lecture pour le fichier
                    {
                        if (!reader.EndOfStream)  //si on n'est pas en fin de fichier 
                        {
                            XmlSerializer deserializer = new XmlSerializer(typeof(List<Client>)); //on initie un objet de désérialisation
                            CompteFormat.aClients = (List<Client>)deserializer.Deserialize(reader); //on desérérialise les objets du fichier xml et on les cast en liste client
                            reader.Close(); //on ferme le flux de lecture de données
                            reader.Dispose(); // et on le detruit 

                        }
                        else
                        {
                            reader.Close();
                            reader.Dispose();
                        }
                    }
                }
                if (File.Exists(@"GesB_acomptes.xml"))
                {
                    using (StreamReader reader = new StreamReader(@"GesB_acomptes.xml"))
                    {
                        if (!reader.EndOfStream)
                        {
                            XmlSerializer deserializer = new XmlSerializer(typeof(List<CompteCourant>));

                            CompteFormat.aComptes = (List<CompteCourant>)deserializer.Deserialize(reader);
                            reader.Close();
                            reader.Dispose();
                        }
                        else
                        {
                            reader.Close();
                            reader.Dispose();
                        }

                    }
                }

                if (File.Exists(@"GesB_acomptesEp.xml"))
                {
                    using (StreamReader reader = new StreamReader(@"GesB_acomptesEp.xml"))
                    {
                        if (!reader.EndOfStream)
                        {
                            XmlSerializer deserializer = new XmlSerializer(typeof(List<CompteEpargne>));

                            CompteFormat.aCompteEp = (List<CompteEpargne>)deserializer.Deserialize(reader);
                            reader.Close();
                            reader.Dispose();
                        }
                        else
                        {
                            reader.Close();
                            reader.Dispose();
                        }

                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Opération impossible", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Methode de sauvegarde desq données dans des fichiers xml

        public static void sauvergardeDonees()
        {
            try
            {
                if (CompteFormat.aClients.Count != 0)
                {
                    if (!File.Exists(@"GesB_client.xml"))
                    {
                        File.Create(@"GesB_client.xml");
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
                        using (StreamWriter writer = new StreamWriter(@"GesB_client.xml"))
                        {
                            serializer.Serialize(writer, CompteFormat.aClients);
                            writer.Close();
                            writer.Dispose();

                        }
                    }
                    else
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
                        using (StreamWriter writer = new StreamWriter(@"GesB_client.xml"))
                        {
                            serializer.Serialize(writer, CompteFormat.aClients);
                            writer.Close();
                            writer.Dispose();

                        }
                    }
                }

                if (CompteFormat.aComptes.Count != 0)
                {
                    if (!File.Exists(@"GesB_acomptes.xml"))
                    {
                        File.Create(@"GesB_acomptes.xml");
                        XmlSerializer serializer = new XmlSerializer(typeof(List<CompteCourant>));
                        using (StreamWriter writer = new StreamWriter(@"GesB_acomptes.xml"))
                        {
                            serializer.Serialize(writer, CompteFormat.aComptes);
                            writer.Close();
                            writer.Dispose();

                        }
                    }
                    else
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<CompteCourant>));
                        using (StreamWriter writer = new StreamWriter(@"GesB_acomptes.xml"))
                        {
                            serializer.Serialize(writer, CompteFormat.aComptes);
                            writer.Close();
                            writer.Dispose();

                        }
                    }
                }

                if (CompteFormat.aCompteEp.Count != 0)
                {
                    if (!File.Exists(@"GesB_acomptesEp.xml"))
                    {
                        File.Create(@"GesB_acomptesEp.xml");
                        XmlSerializer serializer = new XmlSerializer(typeof(List<CompteEpargne>));
                        using (StreamWriter writer = new StreamWriter(@"GesB_acomptesEp.xml"))
                        {
                            serializer.Serialize(writer, CompteFormat.aCompteEp);
                            writer.Close();
                            writer.Dispose();

                        }
                    }
                    else
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<CompteEpargne>));
                        using (StreamWriter writer = new StreamWriter(@"GesB_acomptesEp.xml"))
                        {
                            serializer.Serialize(writer, CompteFormat.aCompteEp);
                            writer.Close();
                            writer.Dispose();

                        }
                    }
                }
                MessageBox.Show("Toutes les données ont été enregistrées avec succès", "Sauvegarde réussi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
