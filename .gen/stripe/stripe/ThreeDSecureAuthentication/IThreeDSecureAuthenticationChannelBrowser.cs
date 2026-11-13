using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace stripe.ThreeDSecureAuthentication
{
    [JsiiInterface(nativeType: typeof(IThreeDSecureAuthenticationChannelBrowser), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelBrowser")]
    public interface IThreeDSecureAuthenticationChannelBrowser
    {
        /// <summary>The HTTP accept headers from the cardholder's browser.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#accept_header ThreeDSecureAuthentication#accept_header}
        /// </remarks>
        [JsiiProperty(name: "acceptHeader", typeJson: "{\"primitive\":\"string\"}")]
        string AcceptHeader
        {
            get;
        }

        /// <summary>The IP address of the browser.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#ip_address ThreeDSecureAuthentication#ip_address}
        /// </remarks>
        [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
        string IpAddress
        {
            get;
        }

        /// <summary>The cardholder browser’s ability to execute JavaScript.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#javascript_enabled ThreeDSecureAuthentication#javascript_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "javascriptEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
        object JavascriptEnabled
        {
            get;
        }

        /// <summary>An IETF BCP 47 language tag representing the browser language.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#language ThreeDSecureAuthentication#language}
        /// </remarks>
        [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
        string Language
        {
            get;
        }

        /// <summary>The browser user agent.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#user_agent ThreeDSecureAuthentication#user_agent}
        /// </remarks>
        [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}")]
        string UserAgent
        {
            get;
        }

        /// <summary>The color depth of the cardholder’s screen.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#color_depth ThreeDSecureAuthentication#color_depth}
        /// </remarks>
        [JsiiProperty(name: "colorDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ColorDepth
        {
            get
            {
                return null;
            }
        }

        /// <summary>Unique and immutable identifier linked to a device that is consistent across 3DS transactions for the specific user device.</summary>
        /// <remarks>
        /// For example: hardware device ID or a platform-calculated device fingerprint.
        ///
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#device_id ThreeDSecureAuthentication#device_id}
        /// </remarks>
        [JsiiProperty(name: "deviceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DeviceId
        {
            get
            {
                return null;
            }
        }

        /// <summary>The cardholder browser’s ability to execute Java.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#java_enabled ThreeDSecureAuthentication#java_enabled}
        /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
        /// </remarks>
        [JsiiProperty(name: "javaEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? JavaEnabled
        {
            get
            {
                return null;
            }
        }

        /// <summary>The total height of the cardholder’s screen in pixels.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#screen_height ThreeDSecureAuthentication#screen_height}
        /// </remarks>
        [JsiiProperty(name: "screenHeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScreenHeight
        {
            get
            {
                return null;
            }
        }

        /// <summary>The total width of the cardholder’s screen in pixels.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#screen_width ThreeDSecureAuthentication#screen_width}
        /// </remarks>
        [JsiiProperty(name: "screenWidth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ScreenWidth
        {
            get
            {
                return null;
            }
        }

        /// <summary>The time difference between UTC time and the local time of the cardholder’s browser, in minutes.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#timezone_offset ThreeDSecureAuthentication#timezone_offset}
        /// </remarks>
        [JsiiProperty(name: "timezoneOffset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimezoneOffset
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IThreeDSecureAuthenticationChannelBrowser), fullyQualifiedName: "stripe.threeDSecureAuthentication.ThreeDSecureAuthenticationChannelBrowser")]
        internal sealed class _Proxy : DeputyBase, stripe.ThreeDSecureAuthentication.IThreeDSecureAuthenticationChannelBrowser
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The HTTP accept headers from the cardholder's browser.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#accept_header ThreeDSecureAuthentication#accept_header}
            /// </remarks>
            [JsiiProperty(name: "acceptHeader", typeJson: "{\"primitive\":\"string\"}")]
            public string AcceptHeader
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The IP address of the browser.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#ip_address ThreeDSecureAuthentication#ip_address}
            /// </remarks>
            [JsiiProperty(name: "ipAddress", typeJson: "{\"primitive\":\"string\"}")]
            public string IpAddress
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The cardholder browser’s ability to execute JavaScript.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#javascript_enabled ThreeDSecureAuthentication#javascript_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiProperty(name: "javascriptEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}")]
            public object JavascriptEnabled
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>An IETF BCP 47 language tag representing the browser language.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#language ThreeDSecureAuthentication#language}
            /// </remarks>
            [JsiiProperty(name: "language", typeJson: "{\"primitive\":\"string\"}")]
            public string Language
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The browser user agent.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#user_agent ThreeDSecureAuthentication#user_agent}
            /// </remarks>
            [JsiiProperty(name: "userAgent", typeJson: "{\"primitive\":\"string\"}")]
            public string UserAgent
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The color depth of the cardholder’s screen.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#color_depth ThreeDSecureAuthentication#color_depth}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "colorDepth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ColorDepth
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Unique and immutable identifier linked to a device that is consistent across 3DS transactions for the specific user device.</summary>
            /// <remarks>
            /// For example: hardware device ID or a platform-calculated device fingerprint.
            ///
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#device_id ThreeDSecureAuthentication#device_id}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deviceId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DeviceId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The cardholder browser’s ability to execute Java.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#java_enabled ThreeDSecureAuthentication#java_enabled}
            /// <para>Type union: either bool or <see cref="Io.Cdktn.IResolvable" /></para>
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "javaEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktn.IResolvable\"}]}}", isOptional: true)]
            public object? JavaEnabled
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>The total height of the cardholder’s screen in pixels.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#screen_height ThreeDSecureAuthentication#screen_height}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "screenHeight", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScreenHeight
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The total width of the cardholder’s screen in pixels.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#screen_width ThreeDSecureAuthentication#screen_width}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "screenWidth", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ScreenWidth
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The time difference between UTC time and the local time of the cardholder’s browser, in minutes.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://registry.terraform.io/providers/stripe/stripe/0.3.1/docs/resources/three_d_secure_authentication#timezone_offset ThreeDSecureAuthentication#timezone_offset}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timezoneOffset", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimezoneOffset
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
