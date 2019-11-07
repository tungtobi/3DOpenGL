precision mediump float;

uniform sampler2D u_texture;
uniform sampler2D u_texture1;
uniform sampler2D u_texture2;
uniform float u_time;

varying vec2 v_uv;

void main()
{
	vec2 disp = texture2D(u_texture1, vec2(v_uv.x, v_uv.y + u_time)).rg;
	vec2 offset = (2.0 * disp - 1.0) * 0.4;
	vec2 uv_displaced = v_uv + offset;
	vec4 fire_color = texture2D(u_texture, uv_displaced);
	vec4 alpha_value = texture2D(u_texture2, v_uv);
	gl_FragColor = fire_color * (1.0, 1.0, 1.0, alpha_value.r);
}
