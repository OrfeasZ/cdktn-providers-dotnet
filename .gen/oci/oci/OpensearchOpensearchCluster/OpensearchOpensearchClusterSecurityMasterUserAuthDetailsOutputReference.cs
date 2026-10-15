using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.OpensearchOpensearchCluster
{
    [JsiiClass(nativeType: typeof(oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsOutputReference), fullyQualifiedName: "oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class OpensearchOpensearchClusterSecurityMasterUserAuthDetailsOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public OpensearchOpensearchClusterSecurityMasterUserAuthDetailsOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected OpensearchOpensearchClusterSecurityMasterUserAuthDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected OpensearchOpensearchClusterSecurityMasterUserAuthDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putUserDetails", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails\"}}]")]
        public virtual void PutUserDetails(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails)}, new object[]{@value});
        }

        [JsiiProperty(name: "userDetails", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsOutputReference\"}")]
        public virtual oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsOutputReference UserDetails
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetailsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "userDetailsInput", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails\"}", isOptional: true)]
        public virtual oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails? UserDetailsInput
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetailsUserDetails?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.opensearchOpensearchCluster.OpensearchOpensearchClusterSecurityMasterUserAuthDetails\"}", isOptional: true)]
        public virtual oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetails? InternalValue
        {
            get => GetInstanceProperty<oci.OpensearchOpensearchCluster.IOpensearchOpensearchClusterSecurityMasterUserAuthDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
