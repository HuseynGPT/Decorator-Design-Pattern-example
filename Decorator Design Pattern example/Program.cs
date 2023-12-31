﻿using System.Data;

interface IDataSource
{
    void writeData(string data);
    void readData(string data);
}



class FileDataSource : IDataSource
{
    private string fileName;


    public FileDataSource(string filename)
    {
        this.fileName = filename;
    }


    public void readData(string data)
    {
        //code
    }

    public void writeData(string data)
    {
        //
    }
}


class DataSourceDecorator : IDataSource
{

    private IDataSource wrappee;

    public DataSourceDecorator(IDataSource datasource)
    {
        wrappee = datasource;
    }


    virtual public void readData(string data)
    {
        //
    }

    virtual public void writeData(string data)
    {
        //    
    }
}



class EncryptionDecorator:DataSourceDecorator
{
    public override void writeData(string data)
    {
        base.writeData(data);
    }

    public override void readData(string data)
    {
        base.readData(data);
    }
}


class CompressionDecorator : DataSourceDecorator
{
    public override void writeData(string data)
    {
        base.writeData(data);
    }

    public override void readData(string data)
    {
        base.readData(data);
    }
}