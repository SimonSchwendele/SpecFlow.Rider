//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a RdGen v1.10.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

using JetBrains.Core;
using JetBrains.Diagnostics;
using JetBrains.Collections;
using JetBrains.Collections.Viewable;
using JetBrains.Lifetimes;
using JetBrains.Serialization;
using JetBrains.Rd;
using JetBrains.Rd.Base;
using JetBrains.Rd.Impl;
using JetBrains.Rd.Tasks;
using JetBrains.Rd.Util;
using JetBrains.Rd.Text;


// ReSharper disable RedundantEmptyObjectCreationArgumentList
// ReSharper disable InconsistentNaming
// ReSharper disable RedundantOverflowCheckingContext


namespace JetBrains.Rider.Model
{
  
  
  /// <summary>
  /// <p>Generated from: SpecflowRiderPluginModel.kt:8</p>
  /// </summary>
  public class SpecflowRiderPluginModel : RdExtBase
  {
    //fields
    //public fields
    [NotNull] public IViewableProperty<string> MyString => _MyString;
    [NotNull] public IViewableProperty<bool> MyBool => _MyBool;
    [NotNull] public IViewableProperty<JetBrains.Rider.Model.MyEnum?> MyEnum => _MyEnum;
    [NotNull] public IViewableMap<string, string> Data => _Data;
    [NotNull] public ISignal<JetBrains.Rider.Model.MyStructure> MyStructure => _MyStructure;
    
    //private fields
    [NotNull] private readonly RdProperty<string> _MyString;
    [NotNull] private readonly RdProperty<bool> _MyBool;
    [NotNull] private readonly RdProperty<JetBrains.Rider.Model.MyEnum?> _MyEnum;
    [NotNull] private readonly RdMap<string, string> _Data;
    [NotNull] private readonly RdSignal<JetBrains.Rider.Model.MyStructure> _MyStructure;
    
    //primary constructor
    private SpecflowRiderPluginModel(
      [NotNull] RdProperty<string> myString,
      [NotNull] RdProperty<bool> myBool,
      [NotNull] RdProperty<JetBrains.Rider.Model.MyEnum?> myEnum,
      [NotNull] RdMap<string, string> data,
      [NotNull] RdSignal<JetBrains.Rider.Model.MyStructure> myStructure
    )
    {
      if (myString == null) throw new ArgumentNullException("myString");
      if (myBool == null) throw new ArgumentNullException("myBool");
      if (myEnum == null) throw new ArgumentNullException("myEnum");
      if (data == null) throw new ArgumentNullException("data");
      if (myStructure == null) throw new ArgumentNullException("myStructure");
      
      _MyString = myString;
      _MyBool = myBool;
      _MyEnum = myEnum;
      _Data = data;
      _MyStructure = myStructure;
      _MyString.OptimizeNested = true;
      _MyBool.OptimizeNested = true;
      _MyEnum.OptimizeNested = true;
      _Data.OptimizeNested = true;
      _MyEnum.ValueCanBeNull = true;
      BindableChildren.Add(new KeyValuePair<string, object>("myString", _MyString));
      BindableChildren.Add(new KeyValuePair<string, object>("myBool", _MyBool));
      BindableChildren.Add(new KeyValuePair<string, object>("myEnum", _MyEnum));
      BindableChildren.Add(new KeyValuePair<string, object>("data", _Data));
      BindableChildren.Add(new KeyValuePair<string, object>("myStructure", _MyStructure));
    }
    //secondary constructor
    internal SpecflowRiderPluginModel (
    ) : this (
      new RdProperty<string>(JetBrains.Rd.Impl.Serializers.ReadString, JetBrains.Rd.Impl.Serializers.WriteString),
      new RdProperty<bool>(JetBrains.Rd.Impl.Serializers.ReadBool, JetBrains.Rd.Impl.Serializers.WriteBool),
      new RdProperty<JetBrains.Rider.Model.MyEnum?>(ReadMyEnumNullable, WriteMyEnumNullable),
      new RdMap<string, string>(JetBrains.Rd.Impl.Serializers.ReadString, JetBrains.Rd.Impl.Serializers.WriteString, JetBrains.Rd.Impl.Serializers.ReadString, JetBrains.Rd.Impl.Serializers.WriteString),
      new RdSignal<JetBrains.Rider.Model.MyStructure>(JetBrains.Rider.Model.MyStructure.Read, JetBrains.Rider.Model.MyStructure.Write)
    ) {}
    //deconstruct trait
    //statics
    
    public static CtxReadDelegate<JetBrains.Rider.Model.MyEnum?> ReadMyEnumNullable = new CtxReadDelegate<JetBrains.Rider.Model.MyEnum>(JetBrains.Rd.Impl.Serializers.ReadEnum<JetBrains.Rider.Model.MyEnum>).NullableStruct();
    
    public static  CtxWriteDelegate<JetBrains.Rider.Model.MyEnum?> WriteMyEnumNullable = new CtxWriteDelegate<JetBrains.Rider.Model.MyEnum>(JetBrains.Rd.Impl.Serializers.WriteEnum<JetBrains.Rider.Model.MyEnum>).NullableStruct();
    
    protected override long SerializationHash => 652449028105363203L;
    
    protected override Action<ISerializers> Register => RegisterDeclaredTypesSerializers;
    public static void RegisterDeclaredTypesSerializers(ISerializers serializers)
    {
      
      serializers.RegisterToplevelOnce(typeof(IdeRoot), IdeRoot.RegisterDeclaredTypesSerializers);
    }
    
    
    //constants
    
    //custom body
    //methods
    //equals trait
    //hash code trait
    //pretty print
    public override void Print(PrettyPrinter printer)
    {
      printer.Println("SpecflowRiderPluginModel (");
      using (printer.IndentCookie()) {
        printer.Print("myString = "); _MyString.PrintEx(printer); printer.Println();
        printer.Print("myBool = "); _MyBool.PrintEx(printer); printer.Println();
        printer.Print("myEnum = "); _MyEnum.PrintEx(printer); printer.Println();
        printer.Print("data = "); _Data.PrintEx(printer); printer.Println();
        printer.Print("myStructure = "); _MyStructure.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
  public static class SolutionSpecflowRiderPluginModelEx
   {
    public static SpecflowRiderPluginModel GetSpecflowRiderPluginModel(this Solution solution)
    {
      return solution.GetOrCreateExtension("specflowRiderPluginModel", () => new SpecflowRiderPluginModel());
    }
  }
  
  
  /// <summary>
  /// <p>Generated from: SpecflowRiderPluginModel.kt:10</p>
  /// </summary>
  public enum MyEnum {
    FirstValue,
    SecondValue
  }
  
  
  /// <summary>
  /// <p>Generated from: SpecflowRiderPluginModel.kt:15</p>
  /// </summary>
  public sealed class MyStructure : IPrintable, IEquatable<MyStructure>
  {
    //fields
    //public fields
    [NotNull] public string ProjectFile {get; private set;}
    [NotNull] public string Target {get; private set;}
    
    //private fields
    //primary constructor
    public MyStructure(
      [NotNull] string projectFile,
      [NotNull] string target
    )
    {
      if (projectFile == null) throw new ArgumentNullException("projectFile");
      if (target == null) throw new ArgumentNullException("target");
      
      ProjectFile = projectFile;
      Target = target;
    }
    //secondary constructor
    //deconstruct trait
    public void Deconstruct([NotNull] out string projectFile, [NotNull] out string target)
    {
      projectFile = ProjectFile;
      target = Target;
    }
    //statics
    
    public static CtxReadDelegate<MyStructure> Read = (ctx, reader) => 
    {
      var projectFile = reader.ReadString();
      var target = reader.ReadString();
      var _result = new MyStructure(projectFile, target);
      return _result;
    };
    
    public static CtxWriteDelegate<MyStructure> Write = (ctx, writer, value) => 
    {
      writer.Write(value.ProjectFile);
      writer.Write(value.Target);
    };
    
    //constants
    
    //custom body
    //methods
    //equals trait
    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != GetType()) return false;
      return Equals((MyStructure) obj);
    }
    public bool Equals(MyStructure other)
    {
      if (ReferenceEquals(null, other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return ProjectFile == other.ProjectFile && Target == other.Target;
    }
    //hash code trait
    public override int GetHashCode()
    {
      unchecked {
        var hash = 0;
        hash = hash * 31 + ProjectFile.GetHashCode();
        hash = hash * 31 + Target.GetHashCode();
        return hash;
      }
    }
    //pretty print
    public void Print(PrettyPrinter printer)
    {
      printer.Println("MyStructure (");
      using (printer.IndentCookie()) {
        printer.Print("projectFile = "); ProjectFile.PrintEx(printer); printer.Println();
        printer.Print("target = "); Target.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
}
