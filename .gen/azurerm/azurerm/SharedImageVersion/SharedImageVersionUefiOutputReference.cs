using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace azurerm.SharedImageVersion
{
    [JsiiClass(nativeType: typeof(azurerm.SharedImageVersion.SharedImageVersionUefiOutputReference), fullyQualifiedName: "azurerm.sharedImageVersion.SharedImageVersionUefiOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class SharedImageVersionUefiOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public SharedImageVersionUefiOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected SharedImageVersionUefiOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SharedImageVersionUefiOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAdditionalSignatures", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignatures\"}}]")]
        public virtual void PutAdditionalSignatures(azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignatures @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignatures)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAdditionalSignatures")]
        public virtual void ResetAdditionalSignatures()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "additionalSignatures", typeJson: "{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignaturesOutputReference\"}")]
        public virtual azurerm.SharedImageVersion.SharedImageVersionUefiAdditionalSignaturesOutputReference AdditionalSignatures
        {
            get => GetInstanceProperty<azurerm.SharedImageVersion.SharedImageVersionUefiAdditionalSignaturesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "additionalSignaturesInput", typeJson: "{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefiAdditionalSignatures\"}", isOptional: true)]
        public virtual azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignatures? AdditionalSignaturesInput
        {
            get => GetInstanceProperty<azurerm.SharedImageVersion.ISharedImageVersionUefiAdditionalSignatures?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "signatureTemplateNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SignatureTemplateNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "signatureTemplateNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SignatureTemplateNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"azurerm.sharedImageVersion.SharedImageVersionUefi\"}", isOptional: true)]
        public virtual azurerm.SharedImageVersion.ISharedImageVersionUefi? InternalValue
        {
            get => GetInstanceProperty<azurerm.SharedImageVersion.ISharedImageVersionUefi?>();
            set => SetInstanceProperty(value);
        }
    }
}
