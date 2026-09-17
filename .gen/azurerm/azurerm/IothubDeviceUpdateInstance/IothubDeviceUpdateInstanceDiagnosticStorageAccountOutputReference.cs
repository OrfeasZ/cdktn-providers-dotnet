using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.IothubDeviceUpdateInstance
{
    [JsiiClass(nativeType: typeof(azurerm.IothubDeviceUpdateInstance.IothubDeviceUpdateInstanceDiagnosticStorageAccountOutputReference), fullyQualifiedName: "azurerm.iothubDeviceUpdateInstance.IothubDeviceUpdateInstanceDiagnosticStorageAccountOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class IothubDeviceUpdateInstanceDiagnosticStorageAccountOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public IothubDeviceUpdateInstanceDiagnosticStorageAccountOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected IothubDeviceUpdateInstanceDiagnosticStorageAccountOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IothubDeviceUpdateInstanceDiagnosticStorageAccountOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetConnectionString")]
        public virtual void ResetConnectionString()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionStringWo")]
        public virtual void ResetConnectionStringWo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetConnectionStringWoVersion")]
        public virtual void ResetConnectionStringWoVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionStringInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectionStringInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionStringWoInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ConnectionStringWoInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "connectionStringWoVersionInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ConnectionStringWoVersionInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "connectionString", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionString
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectionStringWo", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ConnectionStringWo
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "connectionStringWoVersion", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ConnectionStringWoVersion
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.iothubDeviceUpdateInstance.IothubDeviceUpdateInstanceDiagnosticStorageAccount\"}", isOptional: true)]
        public virtual azurerm.IothubDeviceUpdateInstance.IIothubDeviceUpdateInstanceDiagnosticStorageAccount? InternalValue
        {
            get => GetInstanceProperty<azurerm.IothubDeviceUpdateInstance.IIothubDeviceUpdateInstanceDiagnosticStorageAccount?>();
            set => SetInstanceProperty(value);
        }
    }
}
