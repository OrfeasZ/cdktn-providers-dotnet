using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataSafeSecurityPolicyConfig
{
    [JsiiClass(nativeType: typeof(oci.DataSafeSecurityPolicyConfig.DataSafeSecurityPolicyConfigUnifiedAuditPolicyConfigOutputReference), fullyQualifiedName: "oci.dataSafeSecurityPolicyConfig.DataSafeSecurityPolicyConfigUnifiedAuditPolicyConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataSafeSecurityPolicyConfigUnifiedAuditPolicyConfigOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataSafeSecurityPolicyConfigUnifiedAuditPolicyConfigOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataSafeSecurityPolicyConfigUnifiedAuditPolicyConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataSafeSecurityPolicyConfigUnifiedAuditPolicyConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetExcludeDatasafeUser")]
        public virtual void ResetExcludeDatasafeUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "excludeDatasafeUserInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExcludeDatasafeUserInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "excludeDatasafeUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExcludeDatasafeUser
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataSafeSecurityPolicyConfig.DataSafeSecurityPolicyConfigUnifiedAuditPolicyConfig\"}", isOptional: true)]
        public virtual oci.DataSafeSecurityPolicyConfig.IDataSafeSecurityPolicyConfigUnifiedAuditPolicyConfig? InternalValue
        {
            get => GetInstanceProperty<oci.DataSafeSecurityPolicyConfig.IDataSafeSecurityPolicyConfigUnifiedAuditPolicyConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
