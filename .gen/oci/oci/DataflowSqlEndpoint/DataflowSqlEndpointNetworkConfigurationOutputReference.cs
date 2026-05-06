using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataflowSqlEndpoint
{
    [JsiiClass(nativeType: typeof(oci.DataflowSqlEndpoint.DataflowSqlEndpointNetworkConfigurationOutputReference), fullyQualifiedName: "oci.dataflowSqlEndpoint.DataflowSqlEndpointNetworkConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class DataflowSqlEndpointNetworkConfigurationOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public DataflowSqlEndpointNetworkConfigurationOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected DataflowSqlEndpointNetworkConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataflowSqlEndpointNetworkConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccessControlRules", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointNetworkConfigurationAccessControlRules\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutAccessControlRules(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.DataflowSqlEndpoint.IDataflowSqlEndpointNetworkConfigurationAccessControlRules[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataflowSqlEndpoint.IDataflowSqlEndpointNetworkConfigurationAccessControlRules).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataflowSqlEndpoint.IDataflowSqlEndpointNetworkConfigurationAccessControlRules).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessControlRules")]
        public virtual void ResetAccessControlRules()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHostNamePrefix")]
        public virtual void ResetHostNamePrefix()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNsgIds")]
        public virtual void ResetNsgIds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubnetId")]
        public virtual void ResetSubnetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetVcnId")]
        public virtual void ResetVcnId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "accessControlRules", typeJson: "{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointNetworkConfigurationAccessControlRulesList\"}")]
        public virtual oci.DataflowSqlEndpoint.DataflowSqlEndpointNetworkConfigurationAccessControlRulesList AccessControlRules
        {
            get => GetInstanceProperty<oci.DataflowSqlEndpoint.DataflowSqlEndpointNetworkConfigurationAccessControlRulesList>()!;
        }

        [JsiiProperty(name: "privateEndpointIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateEndpointIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publicEndpointIp", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PublicEndpointIp
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessControlRulesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointNetworkConfigurationAccessControlRules\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? AccessControlRulesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "hostNamePrefixInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? HostNamePrefixInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "networkTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetworkTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nsgIdsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? NsgIdsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subnetIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubnetIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "vcnIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VcnIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "hostNamePrefix", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostNamePrefix
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "networkType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetworkType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nsgIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] NsgIds
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subnetId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubnetId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "vcnId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VcnId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.dataflowSqlEndpoint.DataflowSqlEndpointNetworkConfiguration\"}", isOptional: true)]
        public virtual oci.DataflowSqlEndpoint.IDataflowSqlEndpointNetworkConfiguration? InternalValue
        {
            get => GetInstanceProperty<oci.DataflowSqlEndpoint.IDataflowSqlEndpointNetworkConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
