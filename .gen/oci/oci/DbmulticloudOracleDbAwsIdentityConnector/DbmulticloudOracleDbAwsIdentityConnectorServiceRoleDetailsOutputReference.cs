using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DbmulticloudOracleDbAwsIdentityConnector
{
    [JsiiClass(nativeType: typeof(oci.DbmulticloudOracleDbAwsIdentityConnector.DbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetailsOutputReference), fullyQualifiedName: "oci.dbmulticloudOracleDbAwsIdentityConnector.DbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
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
        protected DbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "assumeRoleStatus", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AssumeRoleStatus
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "awsNodes", typeJson: "{\"fqn\":\"oci.dbmulticloudOracleDbAwsIdentityConnector.DbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetailsAwsNodesList\"}")]
        public virtual oci.DbmulticloudOracleDbAwsIdentityConnector.DbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetailsAwsNodesList AwsNodes
        {
            get => GetInstanceProperty<oci.DbmulticloudOracleDbAwsIdentityConnector.DbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetailsAwsNodesList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "servicePrivateEndpointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServicePrivateEndpointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "serviceTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServiceTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "roleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "servicePrivateEndpoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServicePrivateEndpoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "serviceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or <see cref="oci.DbmulticloudOracleDbAwsIdentityConnector.IDbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetails" /></para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"fqn\":\"oci.dbmulticloudOracleDbAwsIdentityConnector.DbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetails\"}]}}", isOptional: true)]
        public virtual object? InternalValue
        {
            get => GetInstanceProperty<object?>();
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case oci.DbmulticloudOracleDbAwsIdentityConnector.IDbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetails cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DbmulticloudOracleDbAwsIdentityConnector.IDbmulticloudOracleDbAwsIdentityConnectorServiceRoleDetails).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
