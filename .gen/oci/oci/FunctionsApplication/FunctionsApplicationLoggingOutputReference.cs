using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.FunctionsApplication
{
    [JsiiClass(nativeType: typeof(oci.FunctionsApplication.FunctionsApplicationLoggingOutputReference), fullyQualifiedName: "oci.functionsApplication.FunctionsApplicationLoggingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class FunctionsApplicationLoggingOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public FunctionsApplicationLoggingOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected FunctionsApplicationLoggingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FunctionsApplicationLoggingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetLineFormat")]
        public virtual void ResetLineFormat()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "lineFormatInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LineFormatInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "lineFormat", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LineFormat
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.functionsApplication.FunctionsApplicationLogging\"}", isOptional: true)]
        public virtual oci.FunctionsApplication.IFunctionsApplicationLogging? InternalValue
        {
            get => GetInstanceProperty<oci.FunctionsApplication.IFunctionsApplicationLogging?>();
            set => SetInstanceProperty(value);
        }
    }
}
