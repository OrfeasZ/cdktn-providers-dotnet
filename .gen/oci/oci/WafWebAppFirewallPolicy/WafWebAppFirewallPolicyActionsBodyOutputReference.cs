using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.WafWebAppFirewallPolicy
{
    [JsiiClass(nativeType: typeof(oci.WafWebAppFirewallPolicy.WafWebAppFirewallPolicyActionsBodyOutputReference), fullyQualifiedName: "oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyActionsBodyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class WafWebAppFirewallPolicyActionsBodyOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public WafWebAppFirewallPolicyActionsBodyOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected WafWebAppFirewallPolicyActionsBodyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected WafWebAppFirewallPolicyActionsBodyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTemplate")]
        public virtual void ResetTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetText")]
        public virtual void ResetText()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "templateInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TemplateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "textInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TextInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "typeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "template", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Template
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "text", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Text
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Type
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.wafWebAppFirewallPolicy.WafWebAppFirewallPolicyActionsBody\"}", isOptional: true)]
        public virtual oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyActionsBody? InternalValue
        {
            get => GetInstanceProperty<oci.WafWebAppFirewallPolicy.IWafWebAppFirewallPolicyActionsBody?>();
            set => SetInstanceProperty(value);
        }
    }
}
