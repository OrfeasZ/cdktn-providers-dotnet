using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsFunction
{
    [JsiiClass(nativeType: typeof(oci.FunctionsFunction.FunctionsFunctionSourceDetailsRuntimeConfigOutputReference), fullyQualifiedName: "oci.functionsFunction.FunctionsFunctionSourceDetailsRuntimeConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FunctionsFunctionSourceDetailsRuntimeConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FunctionsFunctionSourceDetailsRuntimeConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionsFunctionSourceDetailsRuntimeConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionsFunctionSourceDetailsRuntimeConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetFunctionsRuntimeVersionId")]
        public virtual void ResetFunctionsRuntimeVersionId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionsRuntimeNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FunctionsRuntimeNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "functionsRuntimeVersionIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FunctionsRuntimeVersionIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "runtimeConfigTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RuntimeConfigTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "functionsRuntimeName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionsRuntimeName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "functionsRuntimeVersionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FunctionsRuntimeVersionId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "runtimeConfigType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RuntimeConfigType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.functionsFunction.FunctionsFunctionSourceDetailsRuntimeConfig\"}", isOptional: true)]
        public virtual oci.FunctionsFunction.IFunctionsFunctionSourceDetailsRuntimeConfig? InternalValue
        {
            get => GetInstanceProperty<oci.FunctionsFunction.IFunctionsFunctionSourceDetailsRuntimeConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
