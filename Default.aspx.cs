//Criado por Jerônimo Sampaio | https://github.com/jeronimocavalcantesampaio | Junho de 2023
// Linguagem C SHARP 
// .NET 
// BD MSSQL 
// Tudo documentado para melhor compreensão de estudos após 10 anos sem programar em banco de dados MSSQL

using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using Microsoft.SqlServer;
using Microsoft.SqlServer.Server;
using System.Data.SqlClient;
public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {   //Criando a String de Conexao
        string strcon = "Data Source=localhost;Initial Catalog=banco_sampaio;Integrated Security=True";
        //Criando a String de acesso a tabela
        string seltable = "select * from Tabela";
        //criando a conexao com a string de conexao pra dizer onde esta o banco
        SqlConnection conexao = new SqlConnection(strcon);
        //Criando o DataAdapter, serve para selecionar a Tabela
        SqlDataAdapter da = new SqlDataAdapter(seltable, conexao);
        //Dataset � quase a mesma coisa que o DataAdapter, apenas o dataadapter manda os valores
        //da tabela para o dataset (que � quase a mesma coisa  que o datasource)
        DataSet ds = new DataSet();
        //DataAdapter Passa os Valores da tabela que ta na string para o Dataset
        da.Fill(ds, seltable);
        //Criando o Data SOurce da GridView, mas usando o DR
        Grid.DataSource = ds;
        //Listando os Dados na Grid
        Grid.DataBind();
        //Abrindo a Conexao
        conexao.Open();
        ds.Clear();
        conexao.Close();
    }
    void limpar()
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        Label1.Text = "Adcionado com Sucesso !!!";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string strcon = "Data Source=localhost;Initial Catalog=banco_sampaio;Integrated Security=True";
        string seltable = "select * from Tabela";
        string inserir = "insert into tabela(Codigo, Nome, Endereco) values (" + TextBox1.Text +
        ",'" + TextBox2.Text + "','" + TextBox3.Text + "')";
        SqlConnection conexao = new SqlConnection(strcon);
        SqlDataAdapter da = new SqlDataAdapter(seltable, conexao);
        DataSet ds = new DataSet();
        SqlCommand cmdinsert = new SqlCommand(inserir, conexao);
        conexao.Open();
        cmdinsert.ExecuteNonQuery();
        conexao.Close();
        conexao.Open();
        da.Fill(ds, seltable);
        Grid.DataSource = ds;
        Grid.DataBind();
        conexao.Close();
        limpar();
        
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string strcon = "Data Source=localhost;Initial Catalog=banco_sampaio;Integrated Security=True";
        string seltable = "select * from Tabela";
        //Deletar Tudo da Tabela
        string inserir = "delete from tabela";
        SqlConnection conexao = new SqlConnection(strcon);
        SqlDataAdapter da = new SqlDataAdapter(seltable, conexao);
        DataSet ds = new DataSet();
        SqlCommand cmdinsert = new SqlCommand(inserir, conexao);

        conexao.Open();
        cmdinsert.ExecuteNonQuery();
        conexao.Close();
        conexao.Open();
        da.Fill(ds, seltable);
        Grid.DataSource = ds;
        Grid.DataBind();
        conexao.Close();
        Label1.Text = "Todos os Registros Foram Excluido com Sucesso !!!";
    }
}

//Criado por Jerônimo Sampaio | https://github.com/jeronimocavalcantesampaio | Junho de 2023
// Linguagem C SHARP .NET BD MSSQL 
