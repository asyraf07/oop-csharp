class Person
{
    public string nama;
    public int umur;

    public Person() {
        this.nama = "Default";
        this.umur = -1;
    }

    public Person(string nama, int umur) {
        this.nama = nama;
        this.umur = umur;
    }

    public override string ToString()
    {
        return "Nama saya " + nama + ", umur saya "  + umur + " tahun";
    }
}