using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace oci.CertificatesManagementCertificateAuthority
{
    [JsiiClass(nativeType: typeof(oci.CertificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintOutputReference), fullyQualifiedName: "oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktn.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}}]")]
    public class CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintOutputReference : Io.Cdktn.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        public CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintOutputReference(Io.Cdktn.IInterpolatingParent terraformResource, string terraformAttribute): base(_MakeDeputyProps(terraformResource, terraformAttribute))
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
        protected CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintOutputReference(DeputyProps props): base(props)
        {
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtree" />)[]</param>
        [JsiiMethod(name: "putExcludedSubtree", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtree\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutExcludedSubtree(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtree[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtree).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtree).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        /// <param name="value">Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtree" />)[]</param>
        [JsiiMethod(name: "putPermittedSubtree", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtree\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutPermittedSubtree(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtree[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtree).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtree).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetExcludedSubtree")]
        public virtual void ResetExcludedSubtree()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPermittedSubtree")]
        public virtual void ResetPermittedSubtree()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "excludedSubtree", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtreeList\"}")]
        public virtual oci.CertificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtreeList ExcludedSubtree
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtreeList>()!;
        }

        [JsiiProperty(name: "permittedSubtree", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtreeList\"}")]
        public virtual oci.CertificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtreeList PermittedSubtree
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtreeList>()!;
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtree" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludedSubtreeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintExcludedSubtree\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? ExcludedSubtreeInput
        {
            get => GetInstanceProperty<object?>();
        }

        /// <remarks>
        /// <para>Type union: either <see cref="Io.Cdktn.IResolvable" /> or (<see cref="oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtree" />)[]</para>
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "permittedSubtreeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraintPermittedSubtree\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? PermittedSubtreeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"oci.certificatesManagementCertificateAuthority.CertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraint\"}", isOptional: true)]
        public virtual oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraint? InternalValue
        {
            get => GetInstanceProperty<oci.CertificatesManagementCertificateAuthority.ICertificatesManagementCertificateAuthorityCertificateAuthorityRulesNameConstraint?>();
            set => SetInstanceProperty(value);
        }
    }
}
