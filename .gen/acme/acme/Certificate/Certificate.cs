using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace acme.Certificate
{
    /// <summary>Represents a {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs/resources/certificate acme_certificate}.</summary>
    [JsiiClass(nativeType: typeof(acme.Certificate.Certificate), fullyQualifiedName: "acme.certificate.Certificate", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"acme.certificate.CertificateConfig\"}}]")]
    public class Certificate : Io.Cdktn.TerraformResource
    {
        /// <summary>Create a new {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs/resources/certificate acme_certificate} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Certificate(Constructs.Construct scope, string id, acme.Certificate.ICertificateConfig config): base(_MakeDeputyProps(scope, id, config))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, acme.Certificate.ICertificateConfig config)
        {
            return new DeputyProps(new object?[]{scope, id, config});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Certificate(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Certificate(DeputyProps props): base(props)
        {
        }

        /// <summary>Generates CDKTN code for importing a Certificate resource upon running "cdktn plan &lt;stack-name&gt;".</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="importToId">The construct id used in the generated config for the Certificate to import.</param>
        /// <param name="importFromId">The id of the existing Certificate that should be imported.</param>
        /// <param name="provider">? Optional instance of the provider where the Certificate to import is found.</param>
        [JsiiMethod(name: "generateConfigForImport", returnsJson: "{\"type\":{\"fqn\":\"cdktn.ImportableResource\"}}", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"The construct id used in the generated config for the Certificate to import.\"},\"name\":\"importToId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"remarks\":\"Refer to the {@link https://registry.terraform.io/providers/vancluever/acme/2.48.1/docs/resources/certificate#import import section} in the documentation of this resource for the id to use\",\"summary\":\"The id of the existing Certificate that should be imported.\"},\"name\":\"importFromId\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"? Optional instance of the provider where the Certificate to import is found.\"},\"name\":\"provider\",\"optional\":true,\"type\":{\"fqn\":\"cdktn.TerraformProvider\"}}]")]
        public static Io.Cdktn.ImportableResource GenerateConfigForImport(Constructs.Construct scope, string importToId, string importFromId, Io.Cdktn.TerraformProvider? provider = null)
        {
            return InvokeStaticMethod<Io.Cdktn.ImportableResource>(typeof(acme.Certificate.Certificate), new System.Type[]{typeof(Constructs.Construct), typeof(string), typeof(string), typeof(Io.Cdktn.TerraformProvider)}, new object?[]{scope, importToId, importFromId, provider})!;
        }

        [JsiiMethod(name: "putDnsChallenge", parametersJson: "[{\"name\":\"value\",\"type\":{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"acme.certificate.CertificateDnsChallenge\"},\"kind\":\"array\"}}]}}}]")]
        public virtual void PutDnsChallenge(object @value)
        {
            if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
            {
                switch (@value)
                {
                    case Io.Cdktn.IResolvable cast_2ed7d7:
                        break;
                    case acme.Certificate.ICertificateDnsChallenge[] cast_2ed7d7:
                        break;
                    case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_2ed7d7:
                        // Not enough information to type-check...
                        break;
                    case null:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(acme.Certificate.ICertificateDnsChallenge).FullName}[]; received null", nameof(@value));
                    default:
                        throw new System.ArgumentException($"Expected argument {nameof(@value)} to be one of: {typeof(Io.Cdktn.IResolvable).FullName}, {typeof(acme.Certificate.ICertificateDnsChallenge).FullName}[]; received {@value.GetType().FullName}", nameof(@value));
                }
            }
            InvokeInstanceVoidMethod(new System.Type[]{typeof(object)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpChallenge", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"acme.certificate.CertificateHttpChallenge\"}}]")]
        public virtual void PutHttpChallenge(acme.Certificate.ICertificateHttpChallenge @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(acme.Certificate.ICertificateHttpChallenge)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpMemcachedChallenge", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"acme.certificate.CertificateHttpMemcachedChallenge\"}}]")]
        public virtual void PutHttpMemcachedChallenge(acme.Certificate.ICertificateHttpMemcachedChallenge @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(acme.Certificate.ICertificateHttpMemcachedChallenge)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpS3Challenge", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"acme.certificate.CertificateHttpS3Challenge\"}}]")]
        public virtual void PutHttpS3Challenge(acme.Certificate.ICertificateHttpS3Challenge @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(acme.Certificate.ICertificateHttpS3Challenge)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpWebrootChallenge", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"acme.certificate.CertificateHttpWebrootChallenge\"}}]")]
        public virtual void PutHttpWebrootChallenge(acme.Certificate.ICertificateHttpWebrootChallenge @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(acme.Certificate.ICertificateHttpWebrootChallenge)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTlsChallenge", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"acme.certificate.CertificateTlsChallenge\"}}]")]
        public virtual void PutTlsChallenge(acme.Certificate.ICertificateTlsChallenge @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(acme.Certificate.ICertificateTlsChallenge)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCertificateP12Password")]
        public virtual void ResetCertificateP12Password()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertificateRequestPem")]
        public virtual void ResetCertificateRequestPem()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCertTimeout")]
        public virtual void ResetCertTimeout()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCommonName")]
        public virtual void ResetCommonName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDeactivateAuthorizations")]
        public virtual void ResetDeactivateAuthorizations()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDisableCompletePropagation")]
        public virtual void ResetDisableCompletePropagation()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDnsChallenge")]
        public virtual void ResetDnsChallenge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpChallenge")]
        public virtual void ResetHttpChallenge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpMemcachedChallenge")]
        public virtual void ResetHttpMemcachedChallenge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpS3Challenge")]
        public virtual void ResetHttpS3Challenge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpWebrootChallenge")]
        public virtual void ResetHttpWebrootChallenge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetId")]
        public virtual void ResetId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKeyType")]
        public virtual void ResetKeyType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinDaysDynamic")]
        public virtual void ResetMinDaysDynamic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMinDaysRemaining")]
        public virtual void ResetMinDaysRemaining()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMustStaple")]
        public virtual void ResetMustStaple()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreCheckDelay")]
        public virtual void ResetPreCheckDelay()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPreferredChain")]
        public virtual void ResetPreferredChain()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetProfile")]
        public virtual void ResetProfile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPropagationWait")]
        public virtual void ResetPropagationWait()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRecursiveNameservers")]
        public virtual void ResetRecursiveNameservers()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRenewalInfoIgnoreRetryAfter")]
        public virtual void ResetRenewalInfoIgnoreRetryAfter()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRenewalInfoMaxSleep")]
        public virtual void ResetRenewalInfoMaxSleep()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRevokeCertificateOnDestroy")]
        public virtual void ResetRevokeCertificateOnDestroy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRevokeCertificateReason")]
        public virtual void ResetRevokeCertificateReason()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubjectAlternativeNames")]
        public virtual void ResetSubjectAlternativeNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTlsChallenge")]
        public virtual void ResetTlsChallenge()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetUseRenewalInfo")]
        public virtual void ResetUseRenewalInfo()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetValidityDays")]
        public virtual void ResetValidityDays()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "synthesizeHclAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}")]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeHclAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(acme.Certificate.Certificate))!;

        [JsiiProperty(name: "certificateDomain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateDomain
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateNotAfter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateNotAfter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateNotBefore", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateNotBefore
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateP12", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateP12
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificatePem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificatePem
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateSerial", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateSerial
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "certificateUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateDnsChallengeList\"}")]
        public virtual acme.Certificate.CertificateDnsChallengeList DnsChallenge
        {
            get => GetInstanceProperty<acme.Certificate.CertificateDnsChallengeList>()!;
        }

        [JsiiProperty(name: "httpChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpChallengeOutputReference\"}")]
        public virtual acme.Certificate.CertificateHttpChallengeOutputReference HttpChallenge
        {
            get => GetInstanceProperty<acme.Certificate.CertificateHttpChallengeOutputReference>()!;
        }

        [JsiiProperty(name: "httpMemcachedChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpMemcachedChallengeOutputReference\"}")]
        public virtual acme.Certificate.CertificateHttpMemcachedChallengeOutputReference HttpMemcachedChallenge
        {
            get => GetInstanceProperty<acme.Certificate.CertificateHttpMemcachedChallengeOutputReference>()!;
        }

        [JsiiProperty(name: "httpS3Challenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpS3ChallengeOutputReference\"}")]
        public virtual acme.Certificate.CertificateHttpS3ChallengeOutputReference HttpS3Challenge
        {
            get => GetInstanceProperty<acme.Certificate.CertificateHttpS3ChallengeOutputReference>()!;
        }

        [JsiiProperty(name: "httpWebrootChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpWebrootChallengeOutputReference\"}")]
        public virtual acme.Certificate.CertificateHttpWebrootChallengeOutputReference HttpWebrootChallenge
        {
            get => GetInstanceProperty<acme.Certificate.CertificateHttpWebrootChallengeOutputReference>()!;
        }

        [JsiiProperty(name: "issuerPem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IssuerPem
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "privateKeyPem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PrivateKeyPem
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "renewalInfoExplanationUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RenewalInfoExplanationUrl
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "renewalInfoRetryAfter", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RenewalInfoRetryAfter
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "renewalInfoWindowEnd", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RenewalInfoWindowEnd
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "renewalInfoWindowSelected", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RenewalInfoWindowSelected
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "renewalInfoWindowStart", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RenewalInfoWindowStart
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "tlsChallenge", typeJson: "{\"fqn\":\"acme.certificate.CertificateTlsChallengeOutputReference\"}")]
        public virtual acme.Certificate.CertificateTlsChallengeOutputReference TlsChallenge
        {
            get => GetInstanceProperty<acme.Certificate.CertificateTlsChallengeOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountKeyPemInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountKeyPemInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateP12PasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateP12PasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certificateRequestPemInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CertificateRequestPemInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "certTimeoutInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? CertTimeoutInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "commonNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CommonNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deactivateAuthorizationsInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DeactivateAuthorizationsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "disableCompletePropagationInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DisableCompletePropagationInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "dnsChallengeInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktn.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"acme.certificate.CertificateDnsChallenge\"},\"kind\":\"array\"}}]}}", isOptional: true)]
        public virtual object? DnsChallengeInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpChallengeInput", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpChallenge\"}", isOptional: true)]
        public virtual acme.Certificate.ICertificateHttpChallenge? HttpChallengeInput
        {
            get => GetInstanceProperty<acme.Certificate.ICertificateHttpChallenge?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpMemcachedChallengeInput", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpMemcachedChallenge\"}", isOptional: true)]
        public virtual acme.Certificate.ICertificateHttpMemcachedChallenge? HttpMemcachedChallengeInput
        {
            get => GetInstanceProperty<acme.Certificate.ICertificateHttpMemcachedChallenge?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpS3ChallengeInput", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpS3Challenge\"}", isOptional: true)]
        public virtual acme.Certificate.ICertificateHttpS3Challenge? HttpS3ChallengeInput
        {
            get => GetInstanceProperty<acme.Certificate.ICertificateHttpS3Challenge?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpWebrootChallengeInput", typeJson: "{\"fqn\":\"acme.certificate.CertificateHttpWebrootChallenge\"}", isOptional: true)]
        public virtual acme.Certificate.ICertificateHttpWebrootChallenge? HttpWebrootChallengeInput
        {
            get => GetInstanceProperty<acme.Certificate.ICertificateHttpWebrootChallenge?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "keyTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KeyTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minDaysDynamicInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? MinDaysDynamicInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "minDaysRemainingInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MinDaysRemainingInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mustStapleInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? MustStapleInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preCheckDelayInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PreCheckDelayInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "preferredChainInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? PreferredChainInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "profileInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ProfileInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "propagationWaitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? PropagationWaitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "recursiveNameserversInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? RecursiveNameserversInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "renewalInfoIgnoreRetryAfterInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RenewalInfoIgnoreRetryAfterInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "renewalInfoMaxSleepInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? RenewalInfoMaxSleepInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "revokeCertificateOnDestroyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? RevokeCertificateOnDestroyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "revokeCertificateReasonInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RevokeCertificateReasonInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subjectAlternativeNamesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SubjectAlternativeNamesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsChallengeInput", typeJson: "{\"fqn\":\"acme.certificate.CertificateTlsChallenge\"}", isOptional: true)]
        public virtual acme.Certificate.ICertificateTlsChallenge? TlsChallengeInput
        {
            get => GetInstanceProperty<acme.Certificate.ICertificateTlsChallenge?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "useRenewalInfoInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        public virtual object? UseRenewalInfoInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "validityDaysInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ValidityDaysInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "accountKeyPem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountKeyPem
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateP12Password", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateP12Password
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certificateRequestPem", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CertificateRequestPem
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "certTimeout", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double CertTimeout
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "commonName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CommonName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "deactivateAuthorizations", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DeactivateAuthorizations
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "disableCompletePropagation", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object DisableCompletePropagation
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "keyType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KeyType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "minDaysDynamic", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object MinDaysDynamic
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "minDaysRemaining", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MinDaysRemaining
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mustStaple", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object MustStaple
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "preCheckDelay", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PreCheckDelay
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "preferredChain", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string PreferredChain
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "profile", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Profile
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "propagationWait", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double PropagationWait
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "recursiveNameservers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] RecursiveNameservers
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "renewalInfoIgnoreRetryAfter", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object RenewalInfoIgnoreRetryAfter
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "renewalInfoMaxSleep", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double RenewalInfoMaxSleep
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "revokeCertificateOnDestroy", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object RevokeCertificateOnDestroy
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "revokeCertificateReason", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RevokeCertificateReason
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubjectAlternativeNames
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "useRenewalInfo", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        public virtual object UseRenewalInfo
        {
            get => GetInstanceProperty<object>()!;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case Io.Cdktn.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(Io.Cdktn.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                SetInstanceProperty(value);
            }
        }

        [JsiiProperty(name: "validityDays", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ValidityDays
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }
    }
}
