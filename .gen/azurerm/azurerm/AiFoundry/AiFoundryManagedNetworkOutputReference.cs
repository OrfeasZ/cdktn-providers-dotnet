using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.AiFoundry
{
    [JsiiClass(nativeType: typeof(azurerm.AiFoundry.AiFoundryManagedNetworkOutputReference), fullyQualifiedName: "azurerm.aiFoundry.AiFoundryManagedNetworkOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class AiFoundryManagedNetworkOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public AiFoundryManagedNetworkOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected AiFoundryManagedNetworkOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AiFoundryManagedNetworkOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetIsolationMode")]
        public virtual void ResetIsolationMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "isolationModeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IsolationModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "isolationMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IsolationMode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.aiFoundry.AiFoundryManagedNetwork\"}", isOptional: true)]
        public virtual azurerm.AiFoundry.IAiFoundryManagedNetwork? InternalValue
        {
            get => GetInstanceProperty<azurerm.AiFoundry.IAiFoundryManagedNetwork?>();
            set => SetInstanceProperty(value);
        }
    }
}
