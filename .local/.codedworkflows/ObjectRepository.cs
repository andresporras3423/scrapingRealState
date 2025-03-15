using UiPath.CodedWorkflows.DescriptorIntegration;

namespace scrapingRealState.ObjectRepository
{
    public static class Descriptors
    {
        public static class NewApplication
        {
            static string _reference = "Ls64MbztdUqogCOKu_o7Gw/qiMcKqjnwEuBQXpW44oIog";
            public static _Implementation._NewApplication.__Chrome_Inmuebles_en_Venta_en_Bogotá_D_C__Nuevos__ Chrome_Inmuebles_en_Venta_en_Bogotá_D_C__Nuevos__ { get; private set; } = new _Implementation._NewApplication.__Chrome_Inmuebles_en_Venta_en_Bogotá_D_C__Nuevos__();
        }
    }
}

namespace scrapingRealState._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _NewApplication._Chrome_Inmuebles_en_Venta_en_Bogotá_D_C__Nuevos__
    {
        public class __Area_privada : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Area_privada(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "Ls64MbztdUqogCOKu_o7Gw/8F6QW2o0HE-w2c3BNytvCA", DisplayName = "Area privada", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _NewApplication._Chrome_Inmuebles_en_Venta_en_Bogotá_D_C__Nuevos__
    {
        public class __Click__Ordenar_por_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click__Ordenar_por_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "Ls64MbztdUqogCOKu_o7Gw/4Sz4z58xyESKhGIj_whCFQ", DisplayName = "Click 'Ordenar por'", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _NewApplication._Chrome_Inmuebles_en_Venta_en_Bogotá_D_C__Nuevos__
    {
        public class __Get_Text__Ubicación_Principal_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Get_Text__Ubicación_Principal_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "Ls64MbztdUqogCOKu_o7Gw/9qqXn75FKU-YIswj-aUG8g", DisplayName = "Get Text 'Ubicación Principal'", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _NewApplication
    {
        public class __Chrome_Inmuebles_en_Venta_en_Bogotá_D_C__Nuevos__ : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Chrome_Inmuebles_en_Venta_en_Bogotá_D_C__Nuevos__()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "Ls64MbztdUqogCOKu_o7Gw/y2_leA8mHEuke2IwYuG2cA", DisplayName = "Chrome Inmuebles en Venta en Bogotá D.C. Nuevos -", Screen = this};
                Area_privada = new _Implementation._NewApplication._Chrome_Inmuebles_en_Venta_en_Bogotá_D_C__Nuevos__.__Area_privada(this, null);
                Click__Ordenar_por_ = new _Implementation._NewApplication._Chrome_Inmuebles_en_Venta_en_Bogotá_D_C__Nuevos__.__Click__Ordenar_por_(this, null);
                Get_Text__Ubicación_Principal_ = new _Implementation._NewApplication._Chrome_Inmuebles_en_Venta_en_Bogotá_D_C__Nuevos__.__Get_Text__Ubicación_Principal_(this, null);
            }

            public _Implementation._NewApplication._Chrome_Inmuebles_en_Venta_en_Bogotá_D_C__Nuevos__.__Area_privada Area_privada { get; private set; }

            public _Implementation._NewApplication._Chrome_Inmuebles_en_Venta_en_Bogotá_D_C__Nuevos__.__Click__Ordenar_por_ Click__Ordenar_por_ { get; private set; }

            public _Implementation._NewApplication._Chrome_Inmuebles_en_Venta_en_Bogotá_D_C__Nuevos__.__Get_Text__Ubicación_Principal_ Get_Text__Ubicación_Principal_ { get; private set; }
        }
    }
}