﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace SentenceLearner
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace SentenceLearner.SentenceLearner_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[11];
            _typeNameTable[0] = "SentenceLearner.MainPageViewModel";
            _typeNameTable[1] = "Object";
            _typeNameTable[2] = "String";
            _typeNameTable[3] = "Microsoft.Practices.Prism.Commands.DelegateCommand";
            _typeNameTable[4] = "Microsoft.Practices.Prism.Commands.DelegateCommandBase";
            _typeNameTable[5] = "System.Collections.ObjectModel.ObservableCollection`1<SentenceLearner.Item>";
            _typeNameTable[6] = "System.Collections.ObjectModel.Collection`1<SentenceLearner.Item>";
            _typeNameTable[7] = "SentenceLearner.Item";
            _typeNameTable[8] = "SentenceLearner.MainPage";
            _typeNameTable[9] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[10] = "Windows.UI.Xaml.Controls.UserControl";

            _typeTable = new global::System.Type[11];
            _typeTable[0] = typeof(global::SentenceLearner.MainPageViewModel);
            _typeTable[1] = typeof(global::System.Object);
            _typeTable[2] = typeof(global::System.String);
            _typeTable[3] = typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommand);
            _typeTable[4] = typeof(global::Microsoft.Practices.Prism.Commands.DelegateCommandBase);
            _typeTable[5] = typeof(global::System.Collections.ObjectModel.ObservableCollection<global::SentenceLearner.Item>);
            _typeTable[6] = typeof(global::System.Collections.ObjectModel.Collection<global::SentenceLearner.Item>);
            _typeTable[7] = typeof(global::SentenceLearner.Item);
            _typeTable[8] = typeof(global::SentenceLearner.MainPage);
            _typeTable[9] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[10] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_MainPageViewModel() { return new global::SentenceLearner.MainPageViewModel(); }
        private object Activate_5_ObservableCollection() { return new global::System.Collections.ObjectModel.ObservableCollection<global::SentenceLearner.Item>(); }
        private object Activate_6_Collection() { return new global::System.Collections.ObjectModel.Collection<global::SentenceLearner.Item>(); }
        private object Activate_8_MainPage() { return new global::SentenceLearner.MainPage(); }
        private void VectorAdd_5_ObservableCollection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::SentenceLearner.Item>)instance;
            var newItem = (global::SentenceLearner.Item)item;
            collection.Add(newItem);
        }
        private void VectorAdd_6_Collection(object instance, object item)
        {
            var collection = (global::System.Collections.Generic.ICollection<global::SentenceLearner.Item>)instance;
            var newItem = (global::SentenceLearner.Item)item;
            collection.Add(newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  SentenceLearner.MainPageViewModel
                userType = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_0_MainPageViewModel;
                userType.AddMemberName("JapaneseSentense");
                userType.AddMemberName("EnglishSentense");
                userType.AddMemberName("OkCommand");
                userType.AddMemberName("NextCommand");
                userType.AddMemberName("Words");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Object
                xamlType = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  String
                xamlType = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  Microsoft.Practices.Prism.Commands.DelegateCommand
                userType = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Microsoft.Practices.Prism.Commands.DelegateCommandBase"));
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 4:   //  Microsoft.Practices.Prism.Commands.DelegateCommandBase
                userType = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                xamlType = userType;
                break;

            case 5:   //  System.Collections.ObjectModel.ObservableCollection`1<SentenceLearner.Item>
                userType = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("System.Collections.ObjectModel.Collection`1<SentenceLearner.Item>"));
                userType.CollectionAdd = VectorAdd_5_ObservableCollection;
                userType.SetIsReturnTypeStub();
                xamlType = userType;
                break;

            case 6:   //  System.Collections.ObjectModel.Collection`1<SentenceLearner.Item>
                userType = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_6_Collection;
                userType.CollectionAdd = VectorAdd_6_Collection;
                xamlType = userType;
                break;

            case 7:   //  SentenceLearner.Item
                userType = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.AddMemberName("Word");
                userType.AddMemberName("Selected");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  SentenceLearner.MainPage
                userType = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_MainPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 10:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;
            }
            return xamlType;
        }


        private object get_0_MainPageViewModel_JapaneseSentense(object instance)
        {
            var that = (global::SentenceLearner.MainPageViewModel)instance;
            return that.JapaneseSentense;
        }
        private void set_0_MainPageViewModel_JapaneseSentense(object instance, object Value)
        {
            var that = (global::SentenceLearner.MainPageViewModel)instance;
            that.JapaneseSentense = (global::System.String)Value;
        }
        private object get_1_MainPageViewModel_EnglishSentense(object instance)
        {
            var that = (global::SentenceLearner.MainPageViewModel)instance;
            return that.EnglishSentense;
        }
        private void set_1_MainPageViewModel_EnglishSentense(object instance, object Value)
        {
            var that = (global::SentenceLearner.MainPageViewModel)instance;
            that.EnglishSentense = (global::System.String)Value;
        }
        private object get_2_MainPageViewModel_OkCommand(object instance)
        {
            var that = (global::SentenceLearner.MainPageViewModel)instance;
            return that.OkCommand;
        }
        private object get_3_MainPageViewModel_NextCommand(object instance)
        {
            var that = (global::SentenceLearner.MainPageViewModel)instance;
            return that.NextCommand;
        }
        private object get_4_MainPageViewModel_Words(object instance)
        {
            var that = (global::SentenceLearner.MainPageViewModel)instance;
            return that.Words;
        }
        private void set_4_MainPageViewModel_Words(object instance, object Value)
        {
            var that = (global::SentenceLearner.MainPageViewModel)instance;
            that.Words = (global::System.Collections.ObjectModel.ObservableCollection<global::SentenceLearner.Item>)Value;
        }
        private object get_5_Item_Word(object instance)
        {
            var that = (global::SentenceLearner.Item)instance;
            return that.Word;
        }
        private void set_5_Item_Word(object instance, object Value)
        {
            var that = (global::SentenceLearner.Item)instance;
            that.Word = (global::System.String)Value;
        }
        private object get_6_Item_Selected(object instance)
        {
            var that = (global::SentenceLearner.Item)instance;
            return that.Selected;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlMember xamlMember = null;
            global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "SentenceLearner.MainPageViewModel.JapaneseSentense":
                userType = (global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SentenceLearner.MainPageViewModel");
                xamlMember = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlMember(this, "JapaneseSentense", "String");
                xamlMember.Getter = get_0_MainPageViewModel_JapaneseSentense;
                xamlMember.Setter = set_0_MainPageViewModel_JapaneseSentense;
                break;
            case "SentenceLearner.MainPageViewModel.EnglishSentense":
                userType = (global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SentenceLearner.MainPageViewModel");
                xamlMember = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlMember(this, "EnglishSentense", "String");
                xamlMember.Getter = get_1_MainPageViewModel_EnglishSentense;
                xamlMember.Setter = set_1_MainPageViewModel_EnglishSentense;
                break;
            case "SentenceLearner.MainPageViewModel.OkCommand":
                userType = (global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SentenceLearner.MainPageViewModel");
                xamlMember = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlMember(this, "OkCommand", "Microsoft.Practices.Prism.Commands.DelegateCommand");
                xamlMember.Getter = get_2_MainPageViewModel_OkCommand;
                xamlMember.SetIsReadOnly();
                break;
            case "SentenceLearner.MainPageViewModel.NextCommand":
                userType = (global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SentenceLearner.MainPageViewModel");
                xamlMember = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlMember(this, "NextCommand", "Microsoft.Practices.Prism.Commands.DelegateCommand");
                xamlMember.Getter = get_3_MainPageViewModel_NextCommand;
                xamlMember.SetIsReadOnly();
                break;
            case "SentenceLearner.MainPageViewModel.Words":
                userType = (global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SentenceLearner.MainPageViewModel");
                xamlMember = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlMember(this, "Words", "System.Collections.ObjectModel.ObservableCollection`1<SentenceLearner.Item>");
                xamlMember.Getter = get_4_MainPageViewModel_Words;
                xamlMember.Setter = set_4_MainPageViewModel_Words;
                break;
            case "SentenceLearner.Item.Word":
                userType = (global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SentenceLearner.Item");
                xamlMember = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlMember(this, "Word", "String");
                xamlMember.Getter = get_5_Item_Word;
                xamlMember.Setter = set_5_Item_Word;
                break;
            case "SentenceLearner.Item.Selected":
                userType = (global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SentenceLearner.Item");
                xamlMember = new global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlMember(this, "Selected", "Microsoft.Practices.Prism.Commands.DelegateCommand");
                xamlMember.Getter = get_6_Item_Selected;
                xamlMember.SetIsReadOnly();
                break;
            }
            return xamlMember;
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlSystemBaseType
    {
        global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::SentenceLearner.SentenceLearner_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


