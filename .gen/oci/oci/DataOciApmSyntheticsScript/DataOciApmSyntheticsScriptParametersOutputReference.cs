using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciApmSyntheticsScript
{
    [JsiiClass(nativeType: typeof(oci.DataOciApmSyntheticsScript.DataOciApmSyntheticsScriptParametersOutputReference), fullyQualifiedName: "oci.dataOciApmSyntheticsScript.DataOciApmSyntheticsScriptParametersOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciApmSyntheticsScriptParametersOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciApmSyntheticsScriptParametersOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmSyntheticsScriptParametersOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciApmSyntheticsScriptParametersOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "isOverwritten", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsOverwritten
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "isSecret", typeJson: "{\"fqn\":\"cdktn.IResolvable\"}")]
        public virtual Io.Cdktn.IResolvable IsSecret
        {
            get => GetInstanceProperty<Io.Cdktn.IResolvable>()!;
        }

        [JsiiProperty(name: "paramName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParamName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "paramValue", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ParamValue
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "scriptParameter", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsScript.DataOciApmSyntheticsScriptParametersScriptParameterList\"}")]
        public virtual oci.DataOciApmSyntheticsScript.DataOciApmSyntheticsScriptParametersScriptParameterList ScriptParameter
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsScript.DataOciApmSyntheticsScriptParametersScriptParameterList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataOciApmSyntheticsScript.DataOciApmSyntheticsScriptParameters\"}", isOptional: true)]
        public virtual oci.DataOciApmSyntheticsScript.IDataOciApmSyntheticsScriptParameters? InternalValue
        {
            get => GetInstanceProperty<oci.DataOciApmSyntheticsScript.IDataOciApmSyntheticsScriptParameters?>();
            set => SetInstanceProperty(value);
        }
    }
}
