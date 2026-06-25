using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.DataOciDbmulticloudOracleDbAwsIdentityConnectors
{
    [JsiiClass(nativeType: typeof(oci.DataOciDbmulticloudOracleDbAwsIdentityConnectors.DataOciDbmulticloudOracleDbAwsIdentityConnectorsFilterList), fullyQualifiedName: "oci.dataOciDbmulticloudOracleDbAwsIdentityConnectors.DataOciDbmulticloudOracleDbAwsIdentityConnectorsFilterList", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"wrapsSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataOciDbmulticloudOracleDbAwsIdentityConnectorsFilterList : Io.Cdktn.ComplexList
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="wrapsSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataOciDbmulticloudOracleDbAwsIdentityConnectorsFilterList(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, bool wrapsSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, wrapsSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute, bool wrapsSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, wrapsSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDbmulticloudOracleDbAwsIdentityConnectorsFilterList(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataOciDbmulticloudOracleDbAwsIdentityConnectorsFilterList(DeputyProps props): base(props)
        {
        }

        /// <param name="index">the index of the item to return.</param>
        [JsiiMethod(name: "get", returnsJson: "{\"type\":{\"fqn\":\"oci.dataOciDbmulticloudOracleDbAwsIdentityConnectors.DataOciDbmulticloudOracleDbAwsIdentityConnectorsFilterOutputReference\"}}", parametersJson: "[{\"docs\":{\"summary\":\"the index of the item to return.\"},\"name\":\"index\",\"type\":{\"primitive\":\"number\"}}]")]
        public virtual oci.DataOciDbmulticloudOracleDbAwsIdentityConnectors.DataOciDbmulticloudOracleDbAwsIdentityConnectorsFilterOutputReference Get(double index)
        {
            return InvokeInstanceMethod<oci.DataOciDbmulticloudOracleDbAwsIdentityConnectors.DataOciDbmulticloudOracleDbAwsIdentityConnectorsFilterOutputReference>(new System.Type[]{typeof(double)}, new object[]{index})!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.DataOciDbmulticloudOracleDbAwsIdentityConnectors.IDataOciDbmulticloudOracleDbAwsIdentityConnectorsFilter" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.dataOciDbmulticloudOracleDbAwsIdentityConnectors.DataOciDbmulticloudOracleDbAwsIdentityConnectorsFilter\"},\"kind\":\"array\"}}]}}", isOptional: true)]
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
                        case oci.DataOciDbmulticloudOracleDbAwsIdentityConnectors.IDataOciDbmulticloudOracleDbAwsIdentityConnectorsFilter[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            break;
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.DataOciDbmulticloudOracleDbAwsIdentityConnectors.IDataOciDbmulticloudOracleDbAwsIdentityConnectorsFilter).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }
    }
}
