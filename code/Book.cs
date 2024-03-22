namespace Team_1_Library_Create
{
    class Book
    {
        public string Name { get; private set; }
        public string Autor { get; private set; }
        public string PublishYear { get; private set; }

        public Book(string name_, string autor_, string publishYear_)
        {
            setName(name_);
            setAutor(autor_);
            setPublishYear(publishYear_);
        }
        public void setName(string name)
        {
            this.Name = name;
        }
        public void setAutor(string autor)
        {
            this.Autor = autor;
        }
        public void setPublishYear(string year)
        {
            this.PublishYear = year;
        }
    }
}
