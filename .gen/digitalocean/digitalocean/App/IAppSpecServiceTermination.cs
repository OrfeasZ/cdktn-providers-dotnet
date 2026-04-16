using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace digitalocean.App
{
    [JsiiInterface(nativeType: typeof(IAppSpecServiceTermination), fullyQualifiedName: "digitalocean.app.AppSpecServiceTermination")]
    public interface IAppSpecServiceTermination
    {
        /// <summary>The number of seconds to wait between selecting a container instance for termination and issuing the TERM signal.</summary>
        /// <remarks>
        /// Selecting a container instance for termination begins an asynchronous drain of new requests on upstream load-balancers. Default: 15 seconds, Minimum 1, Maximum 110.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#drain_seconds App#drain_seconds}
        /// </remarks>
        [JsiiProperty(name: "drainSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DrainSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of seconds to wait between sending a TERM signal to a container and issuing a KILL which causes immediate shutdown.</summary>
        /// <remarks>
        /// Default: 120, Minimum 1, Maximum 600.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#grace_period_seconds App#grace_period_seconds}
        /// </remarks>
        [JsiiProperty(name: "gracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? GracePeriodSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppSpecServiceTermination), fullyQualifiedName: "digitalocean.app.AppSpecServiceTermination")]
        internal sealed class _Proxy : DeputyBase, digitalocean.App.IAppSpecServiceTermination
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The number of seconds to wait between selecting a container instance for termination and issuing the TERM signal.</summary>
            /// <remarks>
            /// Selecting a container instance for termination begins an asynchronous drain of new requests on upstream load-balancers. Default: 15 seconds, Minimum 1, Maximum 110.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#drain_seconds App#drain_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "drainSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DrainSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The number of seconds to wait between sending a TERM signal to a container and issuing a KILL which causes immediate shutdown.</summary>
            /// <remarks>
            /// Default: 120, Minimum 1, Maximum 600.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/digitalocean/digitalocean/2.84.1/docs/resources/app#grace_period_seconds App#grace_period_seconds}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? GracePeriodSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
