using System;
using System.Collections.Generic;
using System.Text;
public interface IDataSource<T>
{
    List<T> ReadAll();
    T FindById(int id);
}