namespace StronglyTypedParams
{
    public class ParamCell
    {
        protected SoulsFormats.PARAM.Cell Data;
        public object Value
        {
            get => Data.Value;
            set => Data.Value = value;
        }

        public ParamCell(SoulsFormats.PARAM.Cell data)
        {
            Data = data;
        }
    }
}
